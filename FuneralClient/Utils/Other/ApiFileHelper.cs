using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DotZLib;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Tar;
using librsync.net;
using UnityEngine;
using VRC;
using VRC.Core;

namespace VRCheat
{
    // Token: 0x02000007 RID: 7
    public class ApiFileHelper : MonoBehaviour
    {
        // Token: 0x17000009 RID: 9
        // (get) Token: 0x06000028 RID: 40 RVA: 0x000021C6 File Offset: 0x000003C6
        public static ApiFileHelper Instance
        {
            get
            {
                ApiFileHelper.CheckInstance();
                return ApiFileHelper.Instance;
            }
        }

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x06000029 RID: 41 RVA: 0x000020C4 File Offset: 0x000002C4
        public bool DebugEnabled
        {
            get
            {
                return true;
            }
        }

        // Token: 0x0600002A RID: 42 RVA: 0x00003504 File Offset: 0x00001704
        public static void UploadFileAsync(string filename, string existingFileId, string friendlyName, ApiFileHelper.OnFileOpSuccess onSuccess, ApiFileHelper.OnFileOpError onError, ApiFileHelper.OnFileOpProgress onProgress, ApiFileHelper.FileOpCancelQuery cancelQuery)
        {
            ApiFileHelper.Instance.StartCoroutine(ApiFileHelper.Instance.UploadFile(filename, existingFileId, friendlyName, onSuccess, onError, onProgress, cancelQuery));
        }

        // Token: 0x0600002B RID: 43 RVA: 0x00003530 File Offset: 0x00001730
        public static string GetMimeTypeFromExtension(string extension)
        {
            if (extension == ".vrcw")
            {
                return "application/x-world";
            }
            if (extension == ".vrca")
            {
                return "application/x-avatar";
            }
            if (extension == ".dll")
            {
                return "application/x-msdownload";
            }
            if (extension == ".unitypackage")
            {
                return "application/gzip";
            }
            if (extension == ".gz")
            {
                return "application/gzip";
            }
            if (extension == ".jpg")
            {
                return "image/jpg";
            }
            if (extension == ".png")
            {
                return "image/png";
            }
            if (extension == ".sig")
            {
                return "application/x-rsync-signature";
            }
            if (extension == ".delta")
            {
                return "application/x-rsync-delta";
            }
            Debug.LogWarning("Unknown file extension for mime-type: " + extension);
            return "application/octet-stream";
        }

        // Token: 0x0600002C RID: 44 RVA: 0x000021D2 File Offset: 0x000003D2
        public static bool IsGZipCompressed(string filename)
        {
            return ApiFileHelper.GetMimeTypeFromExtension(Path.GetExtension(filename)) == "application/gzip";
        }

        // Token: 0x0600002D RID: 45 RVA: 0x00003600 File Offset: 0x00001800
        public IEnumerator UploadFile(string filename, string existingFileId, string friendlyName, ApiFileHelper.OnFileOpSuccess onSuccess, ApiFileHelper.OnFileOpError onError, ApiFileHelper.OnFileOpProgress onProgress, ApiFileHelper.FileOpCancelQuery cancelQuery)
        {
            Debug.Log(string.Concat(new string[]
            {
                "UploadFile: filename: ",
                filename,
                ", file id: ",
                (!string.IsNullOrEmpty(existingFileId)) ? existingFileId : "<new>",
                ", name: ",
                friendlyName
            }));

            ApiFileHelper.EnableDeltaCompression = RemoteConfig.GetBool("sdkEnableDeltaCompression", false);
            ApiFileHelper.Progress(onProgress, null, "Checking file...", "", 0f);
            if (string.IsNullOrEmpty(filename))
            {
                ApiFileHelper.Error(onError, null, "Upload filename is empty!", "");
                yield break;
            }
            if (!Path.HasExtension(filename))
            {
                ApiFileHelper.Error(onError, null, "Upload filename must have an extension: " + filename, "");
                yield break;
            }
            string str;
            if (!Tools.FileCanRead(filename, out str))
            {
                ApiFileHelper.Error(onError, null, "Could not read file to upload!", filename + "\n" + str);
                yield break;
            }
            ApiFileHelper.Progress(onProgress, null, string.IsNullOrEmpty(existingFileId) ? "Creating file record..." : "Getting file record...", "", 0f);
            bool wait = true;
            bool wasError = false;
            bool worthRetry = false;
            string errorStr = "";
            if (string.IsNullOrEmpty(friendlyName))
            {
                friendlyName = filename;
            }
            string extension = Path.GetExtension(filename);
            string mimeType = ApiFileHelper.GetMimeTypeFromExtension(extension);
            ApiFile apiFile = null;
            Action<ApiContainer> fileSuccess = delegate (ApiContainer c)
            {
                apiFile = (c.Model as ApiFile);
                wait = false;
            };
            Action<ApiContainer> fileFailure = delegate (ApiContainer c)
            {
                errorStr = c.Error;
                wait = false;
                if (c.Code == 400)
                {
                    worthRetry = true;
                }
            };
            for (; ; )
            {
                apiFile = null;
                wait = true;
                worthRetry = false;
                errorStr = "";
                if (string.IsNullOrEmpty(existingFileId))
                {
                    ApiFile.Create(friendlyName, mimeType, extension, fileSuccess, fileFailure);
                }
                else
                {
                    API.Fetch<ApiFile>(existingFileId, fileSuccess, fileFailure, false);
                }
                while (wait)
                {
                    if (apiFile != null && ApiFileHelper.CheckCancelled(cancelQuery, onError, apiFile))
                    {
                        goto Block_12;
                    }
                    yield return null;
                }
                if (!string.IsNullOrEmpty(errorStr))
                {
                    if (errorStr.Contains("File not found"))
                    {
                        Debug.LogError("Couldn't find file record: " + existingFileId + ", creating new file record");
                        existingFileId = "";
                        continue;
                    }
                    string error2 = string.IsNullOrEmpty(existingFileId) ? "Failed to create file record." : "Failed to get file record.";
                    ApiFileHelper.Error(onError, null, error2, errorStr);
                    if (!worthRetry)
                    {
                        goto Block_17;
                    }
                }
                if (!worthRetry)
                {
                    goto IL_52C;
                }
                yield return new WaitForSecondsRealtime(0.75f);
            }
            Block_12:
            yield break;
            Block_17:
            yield break;
            IL_52C:
            if (apiFile == null)
            {
                yield break;
            }
            ApiFileHelper.LogApiFileStatus(apiFile, false);
            while (apiFile.HasQueuedOperation(true))
            {
                wait = true;
                apiFile.DeleteLatestVersion(delegate (ApiContainer c)
                {
                    wait = false;
                }, delegate (ApiContainer c)
                {
                    wait = false;
                });
                while (wait)
                {
                    if (apiFile != null && ApiFileHelper.CheckCancelled(cancelQuery, onError, apiFile))
                    {
                        yield break;
                    }
                    yield return null;
                }
            }
            yield return new WaitForSecondsRealtime(0.75f);
            ApiFileHelper.LogApiFileStatus(apiFile, false);
            if (apiFile.IsInErrorState())
            {
                Debug.LogWarning("ApiFile: " + apiFile.id + ": server failed to process last uploaded, deleting failed version");
                for (; ; )
                {
                    ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Cleaning up previous version", 0f);
                    wait = true;
                    errorStr = "";
                    worthRetry = false;
                    apiFile.DeleteLatestVersion(fileSuccess, fileFailure);
                    while (wait)
                    {
                        if (ApiFileHelper.CheckCancelled(cancelQuery, onError, null))
                        {
                            goto Block_24;
                        }
                        yield return null;
                    }
                    if (!string.IsNullOrEmpty(errorStr))
                    {
                        ApiFileHelper.Error(onError, apiFile, "Failed to delete previous failed version!", errorStr);
                        if (!worthRetry)
                        {
                            goto Block_27;
                        }
                    }
                    if (!worthRetry)
                    {
                        goto IL_7A9;
                    }
                    yield return new WaitForSecondsRealtime(0.75f);
                }
                Block_24:
                yield break;
                Block_27:
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
            }
            IL_7A9:
            yield return new WaitForSecondsRealtime(0.75f);
            ApiFileHelper.LogApiFileStatus(apiFile, false);
            if (apiFile.HasQueuedOperation(true))
            {
                ApiFileHelper.Error(onError, apiFile, "A previous upload is still being processed. Please try again later.", "");
                yield break;
            }
            ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Optimizing file", 0f);
            string uploadFilename = Tools.GetTempFileName(Path.GetExtension(filename), out errorStr, apiFile.id, true);
            if (string.IsNullOrEmpty(uploadFilename))
            {
                ApiFileHelper.Error(onError, apiFile, "Failed to optimize file for upload.", "Failed to create temp file: \n" + errorStr);
                yield break;
            }
            wasError = false;
            yield return base.StartCoroutine(this.CreateOptimizedFileInternal(filename, uploadFilename, delegate (ApiFileHelper.FileOpResult res)
            {
                if (res == ApiFileHelper.FileOpResult.Unchanged)
                {
                    uploadFilename = filename;
                }
            }, delegate (string error)
            {
                ApiFileHelper.Error(onError, apiFile, "Failed to optimize file for upload.", error);
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                wasError = true;
            }));
            if (wasError)
            {
                yield break;
            }
            ApiFileHelper.LogApiFileStatus(apiFile, false);
            ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Generating file hash", 0f);
            string fileMD5Base64 = "";
            wait = true;
            errorStr = "";
            Tools.FileMD5(uploadFilename, delegate (byte[] md5Bytes)
            {
                fileMD5Base64 = Convert.ToBase64String(md5Bytes);
                wait = false;
            }, delegate (string error)
            {
                errorStr = uploadFilename + "\n" + error;
                wait = false;
            });
            while (wait)
            {
                if (ApiFileHelper.CheckCancelled(cancelQuery, onError, apiFile))
                {
                    ApiFileHelper.CleanupTempFiles(apiFile.id);
                    yield break;
                }
                yield return null;
            }
            if (!string.IsNullOrEmpty(errorStr))
            {
                ApiFileHelper.Error(onError, apiFile, "Failed to generate MD5 hash for upload file.", errorStr);
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
            }
            ApiFileHelper.LogApiFileStatus(apiFile, false);
            ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Checking for changes", 0f);
            bool isPreviousUploadRetry = false;
            if (apiFile.HasExistingOrPendingVersion())
            {
                if (string.Compare(fileMD5Base64, apiFile.GetFileMD5(apiFile.GetLatestVersionNumber())) == 0)
                {
                    if (!apiFile.IsWaitingForUpload())
                    {
                        ApiFileHelper.Success(onSuccess, apiFile, "The file to upload is unchanged.");
                        ApiFileHelper.CleanupTempFiles(apiFile.id);
                        yield break;
                    }
                    isPreviousUploadRetry = true;
                    Debug.Log("Retrying previous upload");
                }
                else if (apiFile.IsWaitingForUpload())
                {
                    for (; ; )
                    {
                        ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Cleaning up previous version", 0f);
                        wait = true;
                        worthRetry = false;
                        errorStr = "";
                        apiFile.DeleteLatestVersion(fileSuccess, fileFailure);
                        while (wait)
                        {
                            if (ApiFileHelper.CheckCancelled(cancelQuery, onError, apiFile))
                            {
                                goto Block_38;
                            }
                            yield return null;
                        }
                        if (!string.IsNullOrEmpty(errorStr))
                        {
                            ApiFileHelper.Error(onError, apiFile, "Failed to delete previous incomplete version!", errorStr);
                            if (!worthRetry)
                            {
                                goto Block_41;
                            }
                        }
                        yield return new WaitForSecondsRealtime(0.75f);
                        if (!worthRetry)
                        {
                            goto IL_CCB;
                        }
                    }
                    Block_38:
                    yield break;
                    Block_41:
                    ApiFileHelper.CleanupTempFiles(apiFile.id);
                    yield break;
                }
            }
            IL_CCB:
            ApiFileHelper.LogApiFileStatus(apiFile, false);
            ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Generating signature", 0f);
            string signatureFilename = Tools.GetTempFileName(".sig", out errorStr, apiFile.id, true);
            if (string.IsNullOrEmpty(signatureFilename))
            {
                ApiFileHelper.Error(onError, apiFile, "Failed to generate file signature!", "Failed to create temp file: \n" + errorStr);
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
            }
            wasError = false;
            yield return base.StartCoroutine(this.CreateFileSignatureInternal(uploadFilename, signatureFilename, delegate
            {
            }, delegate (string error)
            {
                ApiFileHelper.Error(onError, apiFile, "Failed to generate file signature!", error);
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                wasError = true;
            }));
            if (wasError)
            {
                yield break;
            }
            ApiFileHelper.LogApiFileStatus(apiFile, false);
            ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Generating signature hash", 0f);
            string sigMD5Base64 = "";
            wait = true;
            errorStr = "";
            Tools.FileMD5(signatureFilename, delegate (byte[] md5Bytes)
            {
                sigMD5Base64 = Convert.ToBase64String(md5Bytes);
                wait = false;
            }, delegate (string error)
            {
                errorStr = signatureFilename + "\n" + error;
                wait = false;
            });
            while (wait)
            {
                if (ApiFileHelper.CheckCancelled(cancelQuery, onError, apiFile))
                {
                    ApiFileHelper.CleanupTempFiles(apiFile.id);
                    yield break;
                }
                yield return null;
            }
            if (!string.IsNullOrEmpty(errorStr))
            {
                ApiFileHelper.Error(onError, apiFile, "Failed to generate MD5 hash for signature file.", errorStr);
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
            }
            long sigFileSize = 0L;
            if (!Tools.GetFileSize(signatureFilename, out sigFileSize, out errorStr))
            {
                ApiFileHelper.Error(onError, apiFile, "Failed to generate file signature!", "Couldn't get file size:\n" + errorStr);
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
            }
            ApiFileHelper.LogApiFileStatus(apiFile, false);
            string existingFileSignaturePath = null;
            if (ApiFileHelper.EnableDeltaCompression && apiFile.HasExistingVersion())
            {
                ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Downloading previous version signature", 0f);
                wait = true;
                errorStr = "";
                apiFile.DownloadSignature(delegate (byte[] data)
                {
                    existingFileSignaturePath = Tools.GetTempFileName(".sig", out errorStr, apiFile.id, true);
                    if (string.IsNullOrEmpty(existingFileSignaturePath))
                    {
                        errorStr = "Failed to create temp file: \n" + errorStr;
                        wait = false;
                        return;
                    }
                    try
                    {
                        File.WriteAllBytes(existingFileSignaturePath, data);
                    }
                    catch (Exception ex)
                    {
                        existingFileSignaturePath = null;
                        errorStr = "Failed to write signature temp file:\n" + ex.Message;
                    }
                    wait = false;
                }, delegate (string error)
                {
                    errorStr = error;
                    wait = false;
                }, delegate (int downloaded, int length)
                {
                    ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Downloading previous version signature", Tools.DivideSafe((float)downloaded, (float)length));
                });
                while (wait)
                {
                    if (ApiFileHelper.CheckCancelled(cancelQuery, onError, apiFile))
                    {
                        ApiFileHelper.CleanupTempFiles(apiFile.id);
                        yield break;
                    }
                    yield return null;
                }
                if (!string.IsNullOrEmpty(errorStr))
                {
                    ApiFileHelper.Error(onError, apiFile, "Failed to download previous file version signature.", errorStr);
                    ApiFileHelper.CleanupTempFiles(apiFile.id);
                    yield break;
                }
            }
            ApiFileHelper.LogApiFileStatus(apiFile, false);
            string deltaFilename = null;
            if (ApiFileHelper.EnableDeltaCompression && !string.IsNullOrEmpty(existingFileSignaturePath))
            {
                ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Creating file delta", 0f);
                deltaFilename = Tools.GetTempFileName(".delta", out errorStr, apiFile.id, true);
                if (string.IsNullOrEmpty(deltaFilename))
                {
                    ApiFileHelper.Error(onError, apiFile, "Failed to create file delta for upload.", "Failed to create temp file: \n" + errorStr);
                    ApiFileHelper.CleanupTempFiles(apiFile.id);
                    yield break;
                }
                wasError = false;
                yield return base.StartCoroutine(this.CreateFileDeltaInternal(uploadFilename, existingFileSignaturePath, deltaFilename, delegate
                {
                }, delegate (string error)
                {
                    ApiFileHelper.Error(onError, apiFile, "Failed to create file delta for upload.", error);
                    ApiFileHelper.CleanupTempFiles(apiFile.id);
                    wasError = true;
                }));
                if (wasError)
                {
                    yield break;
                }
            }
            long fullFizeSize = 0L;
            long deltaFileSize = 0L;
            if (!Tools.GetFileSize(uploadFilename, out fullFizeSize, out errorStr) || (!string.IsNullOrEmpty(deltaFilename) && !Tools.GetFileSize(deltaFilename, out deltaFileSize, out errorStr)))
            {
                ApiFileHelper.Error(onError, apiFile, "Failed to create file delta for upload.", "Couldn't get file size: " + errorStr);
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
            }
            bool uploadDeltaFile = ApiFileHelper.EnableDeltaCompression && deltaFileSize > 0L && deltaFileSize < fullFizeSize;
            if (ApiFileHelper.EnableDeltaCompression)
            {
                Debug.Log(string.Concat(new object[]
                {
                    "Delta size ",
                    deltaFileSize,
                    " (",
                    (float)deltaFileSize / (float)fullFizeSize,
                    " %), full file size ",
                    fullFizeSize,
                    ", uploading ",
                    uploadDeltaFile ? " DELTA" : " FULL FILE"
                }));
            }
            else
            {
                Debug.Log("Delta compression disabled, uploading FULL FILE, size " + fullFizeSize);
            }
            ApiFileHelper.LogApiFileStatus(apiFile, uploadDeltaFile);
            string deltaMD5Base64 = "";
            if (uploadDeltaFile)
            {
                ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Generating file delta hash", 0f);
                wait = true;
                errorStr = "";
                Tools.FileMD5(deltaFilename, delegate (byte[] md5Bytes)
                {
                    deltaMD5Base64 = Convert.ToBase64String(md5Bytes);
                    wait = false;
                }, delegate (string error)
                {
                    errorStr = error;
                    wait = false;
                });
                while (wait)
                {
                    if (ApiFileHelper.CheckCancelled(cancelQuery, onError, apiFile))
                    {
                        ApiFileHelper.CleanupTempFiles(apiFile.id);
                        yield break;
                    }
                    yield return null;
                }
                if (!string.IsNullOrEmpty(errorStr))
                {
                    ApiFileHelper.Error(onError, apiFile, "Failed to generate file delta hash.", errorStr);
                    ApiFileHelper.CleanupTempFiles(apiFile.id);
                    yield break;
                }
            }
            bool versionAlreadyExists = false;
            ApiFileHelper.LogApiFileStatus(apiFile, uploadDeltaFile);
            if (isPreviousUploadRetry)
            {
                ApiFile.Version version = apiFile.GetVersion(apiFile.GetLatestVersionNumber());
                bool flag;
                if (version != null)
                {
                    if (uploadDeltaFile)
                    {
                        flag = (deltaFileSize == (long)version.delta.sizeInBytes && deltaMD5Base64.CompareTo(version.delta.md5) == 0 && sigFileSize == (long)version.signature.sizeInBytes && sigMD5Base64.CompareTo(version.signature.md5) == 0);
                    }
                    else
                    {
                        flag = (fullFizeSize == (long)version.file.sizeInBytes && fileMD5Base64.CompareTo(version.file.md5) == 0 && sigFileSize == (long)version.signature.sizeInBytes && sigMD5Base64.CompareTo(version.signature.md5) == 0);
                    }
                }
                else
                {
                    flag = false;
                }
                if (!flag)
                {
                    ApiFileHelper.Progress(onProgress, apiFile, "Preparing file for upload...", "Cleaning up previous version", 0f);
                    for (; ; )
                    {
                        wait = true;
                        errorStr = "";
                        worthRetry = false;
                        apiFile.DeleteLatestVersion(fileSuccess, fileFailure);
                        while (wait)
                        {
                            if (ApiFileHelper.CheckCancelled(cancelQuery, onError, null))
                            {
                                goto Block_79;
                            }
                            yield return null;
                        }
                        if (!string.IsNullOrEmpty(errorStr))
                        {
                            ApiFileHelper.Error(onError, apiFile, "Failed to delete previous incomplete version!", errorStr);
                            if (!worthRetry)
                            {
                                goto Block_82;
                            }
                        }
                        yield return new WaitForSecondsRealtime(0.75f);
                        if (!worthRetry)
                        {
                            goto IL_1827;
                        }
                    }
                    Block_79:
                    yield break;
                    Block_82:
                    ApiFileHelper.CleanupTempFiles(apiFile.id);
                    yield break;
                }
                versionAlreadyExists = true;
                Debug.Log("Using existing version record");
            }
            IL_1827:
            ApiFileHelper.LogApiFileStatus(apiFile, uploadDeltaFile);
            if (!versionAlreadyExists)
            {
                for (; ; )
                {
                    ApiFileHelper.Progress(onProgress, apiFile, "Creating file version record...", "", 0f);
                    wait = true;
                    errorStr = "";
                    worthRetry = false;
                    if (uploadDeltaFile)
                    {
                        apiFile.CreateNewVersion(ApiFile.Version.FileType.Delta, deltaMD5Base64, deltaFileSize, sigMD5Base64, sigFileSize, fileSuccess, fileFailure);
                    }
                    else
                    {
                        apiFile.CreateNewVersion(ApiFile.Version.FileType.Full, fileMD5Base64, fullFizeSize, sigMD5Base64, sigFileSize, fileSuccess, fileFailure);
                    }
                    while (wait)
                    {
                        if (ApiFileHelper.CheckCancelled(cancelQuery, onError, apiFile))
                        {
                            goto Block_84;
                        }
                        yield return null;
                    }
                    if (!string.IsNullOrEmpty(errorStr))
                    {
                        ApiFileHelper.Error(onError, apiFile, "Failed to create file version record.", errorStr);
                        if (!worthRetry)
                        {
                            goto Block_87;
                        }
                    }
                    yield return new WaitForSecondsRealtime(0.75f);
                    if (!worthRetry)
                    {
                        goto IL_1A18;
                    }
                }
                Block_84:
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
                Block_87:
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
            }
            IL_1A18:
            ApiFileHelper.LogApiFileStatus(apiFile, uploadDeltaFile);
            if (uploadDeltaFile)
            {
                if (apiFile.GetLatestVersion().delta.status == ApiFile.Status.Waiting)
                {
                    ApiFileHelper.Progress(onProgress, apiFile, "Uploading file delta...", "", 0f);
                    wasError = false;
                    yield return base.StartCoroutine(this.UploadFileComponentInternal(apiFile, ApiFile.Version.FileDescriptor.Type.delta, deltaFilename, deltaMD5Base64, deltaFileSize, delegate (ApiFile file)
                    {
                        Debug.Log("Successfully uploaded file delta.");
                        apiFile = file;
                    }, delegate (string error)
                    {
                        ApiFileHelper.Error(onError, apiFile, "Failed to upload file delta.", error);
                        ApiFileHelper.CleanupTempFiles(apiFile.id);
                        wasError = true;
                    }, delegate (long downloaded, long length)
                    {
                        ApiFileHelper.Progress(onProgress, apiFile, "Uploading file delta...", "", Tools.DivideSafe((float)downloaded, (float)length));
                    }, cancelQuery));
                    if (wasError)
                    {
                        yield break;
                    }
                }
            }
            else if (apiFile.GetLatestVersion().file.status == ApiFile.Status.Waiting)
            {
                ApiFileHelper.Progress(onProgress, apiFile, "Uploading file...", "", 0f);
                wasError = false;
                yield return base.StartCoroutine(this.UploadFileComponentInternal(apiFile, ApiFile.Version.FileDescriptor.Type.file, uploadFilename, fileMD5Base64, fullFizeSize, delegate (ApiFile file)
                {
                    Debug.Log("Successfully uploaded file.");
                    apiFile = file;
                }, delegate (string error)
                {
                    ApiFileHelper.Error(onError, apiFile, "Failed to upload file.", error);
                    ApiFileHelper.CleanupTempFiles(apiFile.id);
                    wasError = true;
                }, delegate (long downloaded, long length)
                {
                    ApiFileHelper.Progress(onProgress, apiFile, "Uploading file...", "", Tools.DivideSafe((float)downloaded, (float)length));
                }, cancelQuery));
                if (wasError)
                {
                    yield break;
                }
            }
            ApiFileHelper.LogApiFileStatus(apiFile, uploadDeltaFile);
            if (apiFile.GetLatestVersion().signature.status == ApiFile.Status.Waiting)
            {
                ApiFileHelper.Progress(onProgress, apiFile, "Uploading file signature...", "", 0f);
                wasError = false;
                yield return base.StartCoroutine(this.UploadFileComponentInternal(apiFile, ApiFile.Version.FileDescriptor.Type.signature, signatureFilename, sigMD5Base64, sigFileSize, delegate (ApiFile file)
                {
                    Debug.Log("Successfully uploaded file signature.");
                    apiFile = file;
                }, delegate (string error)
                {
                    ApiFileHelper.Error(onError, apiFile, "Failed to upload file signature.", error);
                    ApiFileHelper.CleanupTempFiles(apiFile.id);
                    wasError = true;
                }, delegate (long downloaded, long length)
                {
                    ApiFileHelper.Progress(onProgress, apiFile, "Uploading file signature...", "", Tools.DivideSafe((float)downloaded, (float)length));
                }, cancelQuery));
                if (wasError)
                {
                    yield break;
                }
            }
            ApiFileHelper.LogApiFileStatus(apiFile, uploadDeltaFile);
            ApiFileHelper.Progress(onProgress, apiFile, "Validating upload...", "", 0f);
            if (!(uploadDeltaFile ? (apiFile.GetFileDescriptor(apiFile.GetLatestVersionNumber(), ApiFile.Version.FileDescriptor.Type.delta).status == ApiFile.Status.Complete) : (apiFile.GetFileDescriptor(apiFile.GetLatestVersionNumber(), ApiFile.Version.FileDescriptor.Type.file).status == ApiFile.Status.Complete)) || apiFile.GetFileDescriptor(apiFile.GetLatestVersionNumber(), ApiFile.Version.FileDescriptor.Type.signature).status != ApiFile.Status.Complete)
            {
                ApiFileHelper.Error(onError, apiFile, "Failed to upload file.", "Record status is not 'complete'");
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
            }
            if (!(uploadDeltaFile ? (apiFile.GetFileDescriptor(apiFile.GetLatestVersionNumber(), ApiFile.Version.FileDescriptor.Type.file).status != ApiFile.Status.Waiting) : (apiFile.GetFileDescriptor(apiFile.GetLatestVersionNumber(), ApiFile.Version.FileDescriptor.Type.delta).status != ApiFile.Status.Waiting)))
            {
                ApiFileHelper.Error(onError, apiFile, "Failed to upload file.", "Record is still in 'waiting' status");
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
            }
            ApiFileHelper.LogApiFileStatus(apiFile, uploadDeltaFile);
            ApiFileHelper.Progress(onProgress, apiFile, "Processing upload...", "", 0f);
            float checkDelay = this.SERVER_PROCESSING_INITIAL_RETRY_TIME;
            float maxDelay = this.SERVER_PROCESSING_MAX_RETRY_TIME;
            float timeout = this.GetServerProcessingWaitTimeoutForDataSize(apiFile.GetLatestVersion().file.sizeInBytes);
            double initialStartTime = (double)Time.realtimeSinceStartup;
            double startTime = initialStartTime;
            while (apiFile.HasQueuedOperation(uploadDeltaFile))
            {
                ApiFileHelper.Progress(onProgress, apiFile, "Processing upload...", "Checking status in " + Mathf.CeilToInt(checkDelay) + " seconds", 0f);
                while ((double)Time.realtimeSinceStartup - startTime < (double)checkDelay)
                {
                    if (ApiFileHelper.CheckCancelled(cancelQuery, onError, apiFile))
                    {
                        ApiFileHelper.CleanupTempFiles(apiFile.id);
                        yield break;
                    }
                    if ((double)Time.realtimeSinceStartup - initialStartTime > (double)timeout)
                    {
                        ApiFileHelper.LogApiFileStatus(apiFile, uploadDeltaFile);
                        ApiFileHelper.Error(onError, apiFile, "Timed out waiting for upload processing to complete.", "");
                        ApiFileHelper.CleanupTempFiles(apiFile.id);
                        yield break;
                    }
                    yield return null;
                }
                do
                {
                    ApiFileHelper.Progress(onProgress, apiFile, "Processing upload...", "Checking status...", 0f);
                    wait = true;
                    worthRetry = false;
                    errorStr = "";
                    API.Fetch<ApiFile>(apiFile.id, fileSuccess, fileFailure, false);
                    while (wait)
                    {
                        if (ApiFileHelper.CheckCancelled(cancelQuery, onError, apiFile))
                        {
                            goto Block_102;
                        }
                        yield return null;
                    }
                    if (!string.IsNullOrEmpty(errorStr))
                    {
                        ApiFileHelper.Error(onError, apiFile, "Checking upload status failed.", errorStr);
                        if (!worthRetry)
                        {
                            goto Block_105;
                        }
                    }
                }
                while (worthRetry);
                checkDelay = Mathf.Min(checkDelay * 2f, maxDelay);
                startTime = (double)Time.realtimeSinceStartup;
                continue;
                Block_102:
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
                Block_105:
                ApiFileHelper.CleanupTempFiles(apiFile.id);
                yield break;
            }
            yield return base.StartCoroutine(this.CleanupTempFilesInternal(apiFile.id));
            ApiFileHelper.Success(onSuccess, apiFile, "Upload complete!");
            yield break;
        }

        // Token: 0x0600002E RID: 46 RVA: 0x00003650 File Offset: 0x00001850
        private static void LogApiFileStatus(ApiFile apiFile, bool checkDelta)
        {
            if (apiFile == null || !apiFile.IsInitialized)
            {
                Debug.LogFormat("<color=yellow>apiFile not initialized</color>", new object[0]);
            }
            else if (apiFile.IsInErrorState())
            {
                Debug.LogFormat("<color=yellow>ApiFile {0} is in an error state.</color>", new object[]
                {
                    apiFile.name
                });
            }
            else
            {
                Debug.LogFormat("<color=yellow>Processing {3}: {0}, {1}, {2}</color>", new object[]
                {
                    apiFile.IsWaitingForUpload() ? "waiting for upload" : "upload complete",
                    apiFile.HasExistingOrPendingVersion() ? "has existing or pending version" : "no previous version",
                    apiFile.IsLatestVersionQueued(checkDelta) ? "latest version queued" : "latest version not queued",
                    apiFile.name
                });
            }
            if (apiFile != null && apiFile.IsInitialized)
            {
                Dictionary<string, object> dictionary = apiFile.ExtractApiFields();
                if (dictionary != null)
                {
                    Debug.LogFormat("<color=yellow>{0}</color>", new object[]
                    {
                        Tools.JsonEncode(dictionary)
                    });
                }
            }
        }

        // Token: 0x0600002F RID: 47 RVA: 0x000021E9 File Offset: 0x000003E9
        public IEnumerator CreateOptimizedFileInternal(string filename, string outputFilename, Action<ApiFileHelper.FileOpResult> onSuccess, Action<string> onError)
        {
            Debug.Log("CreateOptimizedFile: " + filename + " => " + outputFilename);
            if (!ApiFileHelper.IsGZipCompressed(filename))
            {
                Debug.Log("CreateOptimizedFile: (not gzip compressed, done)");
                if (onSuccess != null)
                {
                    onSuccess(ApiFileHelper.FileOpResult.Unchanged);
                }
                yield break;
            }
            bool isUnityPackage = string.Compare(Path.GetExtension(filename), ".unitypackage", true) == 0;
            yield return null;
            Stream inStream = null;
            try
            {
                inStream = new GZipStream(filename, 262144);
            }
            catch (Exception ex)
            {
                if (onError != null)
                {
                    onError("Couldn't read file: " + filename + "\n" + ex.Message);
                }
                yield break;
            }
            yield return null;
            GZipStream outStream = null;
            try
            {
                //outStream = new GZipStream(outputFilename, 9, true, 262144);
            }
            catch (Exception ex2)
            {
                if (inStream != null)
                {
                    inStream.Close();
                }
                if (onError != null)
                {
                    onError("Couldn't create output file: " + outputFilename + "\n" + ex2.Message);
                }
                yield break;
            }
            yield return null;
            if (isUnityPackage)
            {
                try
                {
                    List<string> list = new List<string>();
                    byte[] array = new byte[4096];
                    TarInputStream tarInputStream = new TarInputStream(inStream);
                    for (TarEntry nextEntry = tarInputStream.GetNextEntry(); nextEntry != null; nextEntry = tarInputStream.GetNextEntry())
                    {
                        if (nextEntry.Size > 0L && nextEntry.Name.EndsWith("/pathname", StringComparison.OrdinalIgnoreCase))
                        {
                            int num = tarInputStream.Read(array, 0, (int)nextEntry.Size);
                            if (num > 0)
                            {
                                string assetFilename = Encoding.ASCII.GetString(array, 0, num);
                                if (this.kUnityPackageAssetNameFilters.Any((Regex r) => r.IsMatch(assetFilename)))
                                {
                                    string item = assetFilename.Substring(0, assetFilename.IndexOf('/'));
                                    list.Add(item);
                                }
                            }
                        }
                    }
                    tarInputStream.Close();
                    inStream.Close();
                    inStream = new GZipStream(filename, 262144);
                    TarOutputStream tarOutputStream = new TarOutputStream(outStream);
                    TarInputStream tarInputStream2 = new TarInputStream(inStream);
                    for (TarEntry nextEntry2 = tarInputStream2.GetNextEntry(); nextEntry2 != null; nextEntry2 = tarInputStream2.GetNextEntry())
                    {
                        string assetGuid = nextEntry2.Name.Substring(0, nextEntry2.Name.IndexOf('/'));
                        if (!list.Any((string s) => string.Compare(s, assetGuid) == 0))
                        {
                            tarOutputStream.PutNextEntry(nextEntry2);
                            tarInputStream2.CopyEntryContents(tarOutputStream);
                            tarOutputStream.CloseEntry();
                        }
                    }
                    tarInputStream2.Close();
                    tarOutputStream.Close();
                    goto IL_413;
                }
                catch (Exception ex3)
                {
                    if (inStream != null)
                    {
                        inStream.Close();
                    }
                    if (outStream != null)
                    {
                        outStream.Close();
                    }
                    if (onError != null)
                    {
                        onError("Failed to strip and recompress file.\n" + ex3.Message);
                    }
                    yield break;
                }
            }
            try
            {
                byte[] array2 = new byte[262144];
                StreamUtils.Copy(inStream, outStream, array2);
            }
            catch (Exception ex4)
            {
                if (inStream != null)
                {
                    inStream.Close();
                }
                if (outStream != null)
                {
                    outStream.Close();
                }
                if (onError != null)
                {
                    onError("Failed to recompress file.\n" + ex4.Message);
                }
                yield break;
            }
            IL_413:
            yield return null;
            if (inStream != null)
            {
                inStream.Close();
            }
            inStream = null;
            if (outStream != null)
            {
                outStream.Close();
            }
            outStream = null;
            yield return null;
            if (onSuccess != null)
            {
                onSuccess(ApiFileHelper.FileOpResult.Success);
            }
            yield break;
        }

        // Token: 0x06000030 RID: 48 RVA: 0x00002215 File Offset: 0x00000415
        public IEnumerator CreateFileSignatureInternal(string filename, string outputSignatureFilename, Action onSuccess, Action<string> onError)
        {
            Debug.Log("CreateFileSignature: " + filename + " => " + outputSignatureFilename);
            yield return null;
            Stream inStream = null;
            FileStream outStream = null;
            byte[] buf = new byte[65536];
            IAsyncResult asyncRead = null;
            IAsyncResult asyncWrite = null;
            try
            {
                inStream = Librsync.ComputeSignature(File.OpenRead(filename));
            }
            catch (Exception ex)
            {
                if (onError != null)
                {
                    onError("Couldn't open input file: " + ex.Message);
                }
                yield break;
            }
            try
            {
                outStream = File.Open(outputSignatureFilename, FileMode.Create, FileAccess.Write);
            }
            catch (Exception ex2)
            {
                if (onError != null)
                {
                    onError("Couldn't create output file: " + ex2.Message);
                }
                yield break;
            }
            for (; ; )
            {
                try
                {
                    asyncRead = inStream.BeginRead(buf, 0, buf.Length, null, null);
                    goto IL_17A;
                }
                catch (Exception ex3)
                {
                    if (onError != null)
                    {
                        onError("Couldn't read file: " + ex3.Message);
                    }
                    yield break;
                }
                goto IL_163;
                IL_17A:
                if (asyncRead.IsCompleted)
                {
                    int num = 0;
                    try
                    {
                        num = inStream.EndRead(asyncRead);
                    }
                    catch (Exception ex4)
                    {
                        if (onError != null)
                        {
                            onError("Couldn't read file: " + ex4.Message);
                        }
                        yield break;
                    }
                    if (num > 0)
                    {
                        try
                        {
                            asyncWrite = outStream.BeginWrite(buf, 0, num, null, null);
                            goto IL_237;
                        }
                        catch (Exception ex5)
                        {
                            if (onError != null)
                            {
                                onError("Couldn't write file: " + ex5.Message);
                            }
                            yield break;
                        }
                        goto IL_220;
                        IL_237:
                        if (asyncWrite.IsCompleted)
                        {
                            try
                            {
                                outStream.EndWrite(asyncWrite);
                                continue;
                            }
                            catch (Exception ex6)
                            {
                                if (onError != null)
                                {
                                    onError("Couldn't write file: " + ex6.Message);
                                }
                                yield break;
                            }
                            break;
                        }
                        IL_220:
                        yield return null;
                        goto IL_237;
                    }
                    break;
                }
                IL_163:
                yield return null;
                goto IL_17A;
            }
            inStream.Close();
            outStream.Close();
            yield return null;
            if (onSuccess != null)
            {
                onSuccess();
            }
            yield break;
        }

        // Token: 0x06000031 RID: 49 RVA: 0x0000223A File Offset: 0x0000043A
        public IEnumerator CreateFileDeltaInternal(string newFilename, string existingFileSignaturePath, string outputDeltaFilename, Action onSuccess, Action<string> onError)
        {
            Debug.Log(string.Concat(new string[]
            {
                "CreateFileDelta: ",
                newFilename,
                " (delta) ",
                existingFileSignaturePath,
                " => ",
                outputDeltaFilename
            }));
            yield return null;
            Stream inStream = null;
            FileStream outStream = null;
            byte[] buf = new byte[65536];
            IAsyncResult asyncRead = null;
            IAsyncResult asyncWrite = null;
            try
            {
                inStream = Librsync.ComputeDelta(File.OpenRead(existingFileSignaturePath), File.OpenRead(newFilename));
            }
            catch (Exception ex)
            {
                if (onError != null)
                {
                    onError("Couldn't open input file: " + ex.Message);
                }
                yield break;
            }
            try
            {
                outStream = File.Open(outputDeltaFilename, FileMode.Create, FileAccess.Write);
            }
            catch (Exception ex2)
            {
                if (onError != null)
                {
                    onError("Couldn't create output file: " + ex2.Message);
                }
                yield break;
            }
            for (; ; )
            {
                try
                {
                    asyncRead = inStream.BeginRead(buf, 0, buf.Length, null, null);
                    goto IL_1A8;
                }
                catch (Exception ex3)
                {
                    if (onError != null)
                    {
                        onError("Couldn't read file: " + ex3.Message);
                    }
                    yield break;
                }
                goto IL_191;
                IL_1A8:
                if (asyncRead.IsCompleted)
                {
                    int num = 0;
                    try
                    {
                        num = inStream.EndRead(asyncRead);
                    }
                    catch (Exception ex4)
                    {
                        if (onError != null)
                        {
                            onError("Couldn't read file: " + ex4.Message);
                        }
                        yield break;
                    }
                    if (num > 0)
                    {
                        try
                        {
                            asyncWrite = outStream.BeginWrite(buf, 0, num, null, null);
                            goto IL_265;
                        }
                        catch (Exception ex5)
                        {
                            if (onError != null)
                            {
                                onError("Couldn't write file: " + ex5.Message);
                            }
                            yield break;
                        }
                        goto IL_24E;
                        IL_265:
                        if (asyncWrite.IsCompleted)
                        {
                            try
                            {
                                outStream.EndWrite(asyncWrite);
                                continue;
                            }
                            catch (Exception ex6)
                            {
                                if (onError != null)
                                {
                                    onError("Couldn't write file: " + ex6.Message);
                                }
                                yield break;
                            }
                            break;
                        }
                        IL_24E:
                        yield return null;
                        goto IL_265;
                    }
                    break;
                }
                IL_191:
                yield return null;
                goto IL_1A8;
            }
            inStream.Close();
            outStream.Close();
            yield return null;
            if (onSuccess != null)
            {
                onSuccess();
            }
            yield break;
        }

        // Token: 0x06000032 RID: 50 RVA: 0x00002267 File Offset: 0x00000467
        protected static void Success(ApiFileHelper.OnFileOpSuccess onSuccess, ApiFile apiFile, string message)
        {
            if (apiFile == null)
            {
                apiFile = new ApiFile();
            }
            Debug.Log("ApiFile " + apiFile.ToStringBrief() + ": Operation Succeeded!");
            if (onSuccess != null)
            {
                onSuccess(apiFile, message);
            }
        }

        // Token: 0x06000033 RID: 51 RVA: 0x00003730 File Offset: 0x00001930
        protected static void Error(ApiFileHelper.OnFileOpError onError, ApiFile apiFile, string error, string moreInfo = "")
        {
            if (apiFile == null)
            {
                apiFile = new ApiFile();
            }
            Debug.LogError(string.Concat(new string[]
            {
                "ApiFile ",
                apiFile.ToStringBrief(),
                ": Error: ",
                error,
                "\n",
                moreInfo
            }));
            if (onError != null)
            {
                onError(apiFile, error);
            }
        }

        // Token: 0x06000034 RID: 52 RVA: 0x00002298 File Offset: 0x00000498
        protected static void Progress(ApiFileHelper.OnFileOpProgress onProgress, ApiFile apiFile, string status, string subStatus = "", float pct = 0f)
        {
            if (apiFile == null)
            {
                apiFile = new ApiFile();
            }
            if (onProgress != null)
            {
                onProgress(apiFile, status, subStatus, pct);
            }
        }

        // Token: 0x06000035 RID: 53 RVA: 0x0000378C File Offset: 0x0000198C
        protected static bool CheckCancelled(ApiFileHelper.FileOpCancelQuery cancelQuery, ApiFileHelper.OnFileOpError onError, ApiFile apiFile)
        {
            if (apiFile == null)
            {
                Debug.LogError("apiFile was null");
                return true;
            }
            if (cancelQuery != null && cancelQuery(apiFile))
            {
                Debug.Log("ApiFile " + apiFile.ToStringBrief() + ": Operation cancelled");
                if (onError != null)
                {
                    onError(apiFile, "Cancelled by user.");
                }
                return true;
            }
            return false;
        }

        // Token: 0x06000036 RID: 54 RVA: 0x000022B2 File Offset: 0x000004B2
        protected static void CleanupTempFiles(string subFolderName)
        {
            ApiFileHelper.Instance.StartCoroutine(ApiFileHelper.Instance.CleanupTempFilesInternal(subFolderName));
        }

        // Token: 0x06000037 RID: 55 RVA: 0x000022CA File Offset: 0x000004CA
        protected IEnumerator CleanupTempFilesInternal(string subFolderName)
        {
            if (!string.IsNullOrEmpty(subFolderName))
            {
                string folder = Tools.GetTempFolderPath(subFolderName);
                while (Directory.Exists(folder))
                {
                    try
                    {
                        if (Directory.Exists(folder))
                        {
                            Directory.Delete(folder, true);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    yield return null;
                }
                folder = null;
            }
            yield break;
        }

        // Token: 0x06000038 RID: 56 RVA: 0x000037E0 File Offset: 0x000019E0
        private static void CheckInstance()
        {
            if (ApiFileHelper.mInstance == null)
            {
                GameObject gameObject = new GameObject("ApiFileHelper");
                ApiFileHelper.mInstance = gameObject.AddComponent<ApiFileHelper>();
                try
                {
                    UnityEngine.Object.DontDestroyOnLoad(gameObject);
                }
                catch
                {
                }
            }
        }

        // Token: 0x06000039 RID: 57 RVA: 0x000022D9 File Offset: 0x000004D9
        private float GetServerProcessingWaitTimeoutForDataSize(int size)
        {
            return Mathf.Clamp(Mathf.Ceil((float)size / (float)this.SERVER_PROCESSING_WAIT_TIMEOUT_CHUNK_SIZE) * this.SERVER_PROCESSING_WAIT_TIMEOUT_PER_CHUNK_SIZE, this.SERVER_PROCESSING_WAIT_TIMEOUT_PER_CHUNK_SIZE, this.SERVER_PROCESSING_MAX_WAIT_TIMEOUT);
        }

        // Token: 0x0600003A RID: 58 RVA: 0x0000382C File Offset: 0x00001A2C
        private bool uploadFileComponentValidateFileDesc(ApiFile apiFile, string filename, string md5Base64, long fileSize, ApiFile.Version.FileDescriptor fileDesc, Action<ApiFile> onSuccess, Action<string> onError)
        {
            if (fileDesc.status != ApiFile.Status.Waiting)
            {
                Debug.Log("UploadFileComponent: (file record not in waiting status, done)");
                if (onSuccess != null)
                {
                    onSuccess(apiFile);
                }
                return false;
            }
            if (fileSize != (long)fileDesc.sizeInBytes)
            {
                if (onError != null)
                {
                    onError("File size does not match version descriptor");
                }
                return false;
            }
            if (string.Compare(md5Base64, fileDesc.md5) != 0)
            {
                if (onError != null)
                {
                    onError("File MD5 does not match version descriptor");
                }
                return false;
            }
            long num = 0L;
            string text = "";
            if (!Tools.GetFileSize(filename, out num, out text))
            {
                if (onError != null)
                {
                    onError("Couldn't get file size");
                }
                return false;
            }
            if (num != fileSize)
            {
                if (onError != null)
                {
                    onError("File size does not match input size");
                }
                return false;
            }
            return true;
        }

        // Token: 0x0600003B RID: 59 RVA: 0x00002302 File Offset: 0x00000502
        private IEnumerator uploadFileComponentDoSimpleUpload(ApiFile apiFile, ApiFile.Version.FileDescriptor.Type fileDescriptorType, string filename, string md5Base64, long fileSize, Action<ApiFile> onSuccess, Action<string> onError, Action<long, long> onProgess, ApiFileHelper.FileOpCancelQuery cancelQuery)
        {
            yield return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000038DC File Offset: 0x00001ADC
		private IEnumerator uploadFileComponentDoMultipartUpload(ApiFile apiFile, ApiFile.Version.FileDescriptor.Type fileDescriptorType, string filename, string md5Base64, long fileSize, Action<ApiFile> onSuccess, Action<string> onError, Action<long, long> onProgess, ApiFileHelper.FileOpCancelQuery cancelQuery)
        {
            yield return null;
        }

		// Token: 0x0600003E RID: 62 RVA: 0x0000392C File Offset: 0x00001B2C
		private IEnumerator UploadFileComponentInternal(ApiFile apiFile, ApiFile.Version.FileDescriptor.Type fileDescriptorType, string filename, string md5Base64, long fileSize, Action<ApiFile> onSuccess, Action<string> onError, Action<long, long> onProgess, ApiFileHelper.FileOpCancelQuery cancelQuery)
		{
			Debug.Log(string.Concat(new object[]
			{
				"UploadFileComponent: ",
				fileDescriptorType,
				" (",
				apiFile.id,
				"): ",
				filename
			}));
			ApiFile.Version.FileDescriptor fileDesc = apiFile.GetFileDescriptor(apiFile.GetLatestVersionNumber(), fileDescriptorType);
			if (!this.uploadFileComponentValidateFileDesc(apiFile, filename, md5Base64, fileSize, fileDesc, onSuccess, onError))
			{
				yield break;
			}
			ApiFile.Category category = fileDesc.category;
			if (category != ApiFile.Category.Simple)
			{
				if (category != ApiFile.Category.Multipart)
				{
					if (onError != null)
					{
						onError("Unknown file category type: " + fileDesc.category);
					}
					yield break;
				}
				yield return this.uploadFileComponentDoMultipartUpload(apiFile, fileDescriptorType, filename, md5Base64, fileSize, onSuccess, onError, onProgess, cancelQuery);
			}
			else
			{
				yield return this.uploadFileComponentDoSimpleUpload(apiFile, fileDescriptorType, filename, md5Base64, fileSize, onSuccess, onError, onProgess, cancelQuery);
			}
			//yield return this.uploadFileComponentVerifyRecord(apiFile, fileDescriptorType, filename, md5Base64, fileSize, fileDesc, onSuccess, onError, onProgess, cancelQuery);
			yield break;
		}

		// Token: 0x0400000B RID: 11
		private readonly int kMultipartUploadChunkSize = 10485760;

		// Token: 0x0400000C RID: 12
		private readonly int SERVER_PROCESSING_WAIT_TIMEOUT_CHUNK_SIZE = 52428800;

		// Token: 0x0400000D RID: 13
		private readonly float SERVER_PROCESSING_WAIT_TIMEOUT_PER_CHUNK_SIZE = 120f;

		// Token: 0x0400000E RID: 14
		private readonly float SERVER_PROCESSING_MAX_WAIT_TIMEOUT = 600f;

		// Token: 0x0400000F RID: 15
		private readonly float SERVER_PROCESSING_INITIAL_RETRY_TIME = 2f;

		// Token: 0x04000010 RID: 16
		private readonly float SERVER_PROCESSING_MAX_RETRY_TIME = 10f;

		// Token: 0x04000011 RID: 17
		private static bool EnableDeltaCompression;

		// Token: 0x04000012 RID: 18
		private readonly Regex[] kUnityPackageAssetNameFilters = new Regex[]
		{
			new Regex("/LightingData\\.asset$"),
			new Regex("/Lightmap-.*(\\.png|\\.exr)$"),
			new Regex("/ReflectionProbe-.*(\\.exr|\\.png)$"),
			new Regex("/Editor/Data/UnityExtensions/")
		};

		// Token: 0x04000013 RID: 19
		private static ApiFileHelper mInstance;

		// Token: 0x04000014 RID: 20
		private const float kPostWriteDelay = 0.75f;

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000042 RID: 66
		public delegate void OnFileOpSuccess(ApiFile apiFile, string message);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000046 RID: 70
		public delegate void OnFileOpError(ApiFile apiFile, string error);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600004A RID: 74
		public delegate void OnFileOpProgress(ApiFile apiFile, string status, string subStatus, float pct);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600004E RID: 78
		public delegate bool FileOpCancelQuery(ApiFile apiFile);

		// Token: 0x0200000C RID: 12
		public enum FileOpResult
		{
			// Token: 0x04000016 RID: 22
			Success,
			// Token: 0x04000017 RID: 23
			Unchanged
		}
	}
}
