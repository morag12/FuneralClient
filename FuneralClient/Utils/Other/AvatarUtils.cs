using Decompression;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using VRC.Core;

namespace VRCheat.Utils
{
    // Token: 0x02000027 RID: 39
    public static class AvatarUtils
    {
        // Token: 0x060000CE RID: 206 RVA: 0x00007D98 File Offset: 0x00005F98
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

        // Token: 0x060000CF RID: 207 RVA: 0x00007DFC File Offset: 0x00005FFC
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

        // Token: 0x060000D0 RID: 208 RVA: 0x00007E50 File Offset: 0x00006050
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

        // Token: 0x060000D1 RID: 209 RVA: 0x000029F3 File Offset: 0x00000BF3
        public static ApiAvatar SaveAvatar(VRCPlayer vrcPlayer, string name, string imageUrl = "")
        {
            return AvatarUtils.SaveAvatar(vrcPlayer.JNPEIKGHBEC, name, imageUrl);
        }

        // Token: 0x060000D2 RID: 210 RVA: 0x00007EC0 File Offset: 0x000060C0
        public static ApiAvatar SaveAvatar(ApiAvatar avatar, string name, string imageUrl = "")
        {
            /*
            Console.WriteLine("Saving avatar...");
            ServicePointManager.ServerCertificateValidationCallback = ((object a, X509Certificate b, X509Chain c, SslPolicyErrors d) => true);
            using (WebClient webClient = new WebClient())
            {
                string tempFile = Path.GetTempPath() + Path.GetRandomFileName() + ".vrca";
                try
                {
                    string friendlyName = $"{Path.GetRandomFileName()}-{new System.Random().Next(1, 99999)}";
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

                            ApiFileHelper.UploadFileAsync(filename, existingFileId2, friendlyName2, onSuccess2, onError2, delegate (ApiFile _, string b, string d, float e)
                            {
                            }, (ApiFile _) => false);

                            ApiFileHelper.UploadFileAsync(tempFile, existingFileId, friendlyName, onSuccess, onError, delegate (ApiFile az, string b, string d, float e)
                            {

                            }, (ApiFile _) => false);
                        }, null);
                    };
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error saving avatar: {0}", ex.Message);
                    File.Delete(tempFile);
                }
            }
            return avatar;
            */

            return null;
        }
    }
}
