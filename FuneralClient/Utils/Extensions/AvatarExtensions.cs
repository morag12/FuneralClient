using Decompression;
using FuneralClient.Utils.Other;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using VRC.Core;

namespace FuneralClient.Utils.Extensions
{

    public static class AvatarExtensions
    {
        static MethodInfo renderElem;
        static AvatarExtensions()
        {
            //Look for method with a <T> in it
            renderElem = typeof(UiVRCList).GetMethods().First(z => z.Name.ToLower() == "fnocmlicmcb");
        }

        public static UiVRCList RenderElement(this UiVRCList uivrclist, List<ApiAvatar> AvatarList)
        {
            return (UiVRCList)renderElem.Invoke(uivrclist, AvatarList.ToArray());
        }

        public static void Init(this ApiAvatar avatar, string id, APIUser user, string name, string imageUrl, string assetUrl, string description, string releaseStatus, List<string> tags, string packageUrl = null)
        {
            avatar.id = id;
            avatar.authorName = user.displayName;
            avatar.authorId = user.id;
            avatar.name = name;
            avatar.assetUrl = assetUrl;
            avatar.imageUrl = imageUrl;
            avatar.description = description;
            avatar.releaseStatus = releaseStatus;
            avatar.tags = tags;
            avatar.unityPackageUrl = packageUrl;
        }

        // Token: 0x060000CF RID: 207 RVA: 0x00007CF4 File Offset: 0x00005EF4
        public static void DeleteAvatar(ApiAvatar avatar)
        {
            avatar.Delete(delegate (ApiContainer s)
            {
                Console.WriteLine("Avatar deleted.");
            }, delegate (ApiContainer e)
            {
                Console.WriteLine("Error deleting avatar: {0}", e.Error);
            });
        }

        // Token: 0x060000D0 RID: 208 RVA: 0x00007D48 File Offset: 0x00005F48
        private static void DownloadVRCImage(string address, string outFileName, out string finalFilePath)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] bytes = webClient.DownloadData(address);
                finalFilePath = outFileName + '.' + webClient.ResponseHeaders[HttpResponseHeader.ContentType].Split(new char[]
                {
                    '/'
                })[1];
                File.WriteAllBytes(finalFilePath, bytes);
            }
        }

        public static void SaveAvatar(this ApiAvatar avatar, APIUser who, string name, string description, string imageUrl = "")
        {
            /*
            ServicePointManager.ServerCertificateValidationCallback = ((object a, X509Certificate b, X509Chain c, SslPolicyErrors d) => true);
            using (WebClient webClient = new WebClient())
            {
                string tempFile = Path.GetTempPath() + Path.GetRandomFileName() + ".vrca";
                try
                {
                    string friendlyName = MiscUtils.CalculateHash<MD5>(Guid.NewGuid().ToString()) + Path.GetRandomFileName();
                    webClient.DownloadFile(avatar.assetUrl, tempFile);
                    Console.WriteLine("Decompressing...");
                    AssetBundle assetBundle = new AssetBundle(tempFile);
                    Console.WriteLine("Decompressed...");
                    ApiFile.Create(friendlyName, "application/x-avatar", ".vrca", delegate (ApiContainer s)
                    {
                        string assetUrl = string.Format("https://api.vrchat.cloud/api/1/file/{0}/1/file", s.Model.id);
                        ApiAvatar newAvatar = new ApiAvatar();
                        newAvatar.Init(null, APIUser.CurrentUser, name, avatar.imageUrl, assetUrl, avatar.description, "private", null, null);

                        newAvatar.Save(delegate (ApiContainer success)
                        {
                            Console.WriteLine("Changing blueprint id...");
                            assetBundle.SetAvatarId(success.Model.id);
                            Console.WriteLine("Recompressing...");
                            assetBundle.SaveTo(tempFile);
                            Console.WriteLine("Uploading file...");
                            string existingFileId = null;
                            ApiFileHelper.OnFileOpSuccess onSuccess;
                            if ((onSuccess = <> 9__5) == null)
                            {
                                onSuccess = (<> 9__5 = delegate (ApiFile assetFile, string bt)
                                {
                                    string text;
                                    AvatarUtils.DownloadVRCImage(avatar.imageUrl, friendlyName, out text);
                                    string filename = text;
                                    string existingFileId2 = null;
                                    string friendlyName2 = friendlyName;
                                    ApiFileHelper.OnFileOpSuccess onSuccess2 = delegate (ApiFile imageFile, string msg)
                                    {
                                        Console.WriteLine("Saving ApiAvatar...");
                                        newAvatar.imageUrl = imageFile.GetFileURL();
                                        newAvatar.assetUrl = assetFile.GetFileURL();
                                        newAvatar.Save(delegate (ApiContainer succ)
                                        {
                                            Console.WriteLine("Avatar saved!");
                                        }, delegate (ApiContainer er)
                                        {
                                            Console.WriteLine(er.Error);
                                        });
                                    };
                                    ApiFileHelper.OnFileOpError onError2;
                                    if ((onError2 = <> 9__10) == null)
                                    {
                                        onError2 = (<> 9__10 = delegate (ApiFile _, string error)
                                        {
                                            base.< SaveAvatar > g__OnError | 1(error);
                                        });
                                    }
                                    ApiFileHelper.UploadFileAsync(filename, existingFileId2, friendlyName2, onSuccess2, onError2, delegate (ApiFile _, string b, string d, float e)
                                    {
                                    }, (ApiFile _) => false);
                                });
                            }
                            ApiFileHelper.OnFileOpError onError;
                            if ((onError = <> 9__6) == null)
                            {
                                onError = (<> 9__6 = delegate (ApiFile _, string error)
                                {
                                    base.< SaveAvatar > g__OnError | 1(error);
                                });
                            }
                            ApiFileHelper.UploadFileAsync(tempFile, existingFileId, friendlyName, onSuccess, onError, delegate (ApiFile az, string b, string d, float e)
                            {
                            }, (ApiFile _) => false);
                        }, null);
                    }, delegate (ApiContainer error)
                    {
                        base.< SaveAvatar > g__OnError | 1(error.Error);
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error saving avatar: {0}", ex.Message);
                    File.Delete(tempFile);
                }
            }
            */

            ApiAvatar apiAvatar = avatar;
            ApiAvatar apiAvatar2 = new ApiAvatar();

            apiAvatar2.Init(apiAvatar.id, who, name, imageUrl, apiAvatar.assetUrl, description, apiAvatar.releaseStatus, apiAvatar.tags, apiAvatar.unityPackageUrl);

            apiAvatar2.Save(new Action<ApiContainer>(delegate
            {
                OnAvatarSaved();
            }), new Action<ApiContainer>(delegate
            {
                OnAvatarSaveFailed();
            }));
        }

        public static void OnAvatarSaved()
        {
            if (Configuration.config.VRNotifications)
            {
                GeneralUtils.Notify("Yoinked Avatar Successfully!");
            }

            GeneralUtils.Debug("Successfully Yoinked Avatar!", "yellow");
        }

        public static void OnAvatarSaveFailed()
        {
            if (Configuration.config.VRNotifications)
            {
                GeneralUtils.Notify("Failed to Yoink Avatar.");
            }

            GeneralUtils.Debug("Failed to Yoink Avatar.", "red");
        }
    }
}
