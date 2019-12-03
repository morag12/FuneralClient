using FuneralClient.Utils;
using FuneralClient.Utils.Extensions;
using FuneralClient.Utils.Other;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using VRC;
using VRC.Core;

namespace Funeral
{
    // Token: 0x020003A6 RID: 934
    public class AntiCrash : MonoBehaviour
    {
        // Token: 0x06001A4C RID: 6732 RVA: 0x00034914 File Offset: 0x00032B14
        public IEnumerator Start()
        {
            AntiCrash.instance = this;
            AntiCrash.removedCrash = new Dictionary<string, DateTime>();
            AntiCrash.removedMesh = new Dictionary<string, DateTime>();
            yield return new WaitForSecondsRealtime(1f);
            yield break;
        }

        // Token: 0x06001A4D RID: 6733 RVA: 0x00034930 File Offset: 0x00032B30
        internal static IEnumerator CheckAvatar(Player player)
        {
            yield return new WaitForSecondsRealtime(1f);

            if (player.GetAvatarID() == "avtr_741d47e3-0e4b-4541-a7f9-15848b739495" || player.GetAvatarID() == "avtr_415c4bb8-5723-44f5-86f6-e35ecd7ce57f" || player.GetAvatarID() == "avtr_415c4bb8-5723-44f5-86f6-e35ecd7ce57f")
            {
                player.ApplyHide(true);
                UnityEngine.Object.Destroy(player.vrcPlayer.avatarGameObject);
            }
            yield break;
        }

        // Token: 0x06001A4E RID: 6734 RVA: 0x0003494C File Offset: 0x00032B4C
        internal static void CheckAvOnLoaded()
        {
            if (Configuration.config.AntiCrash)
            {
                foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Player"))
                {
                    string[] array2 = new Regex("\\s").Split(gameObject.name.ToLower());
                    string text = array2[array2.Length - 1].Trim();
                    if (text.Contains("customavatar"))
                    {
                        int j = PlayerManager.GetPlayer(APIUser.CurrentUser.id).BILIBAMEKKJ.GPMJOAAKNPJ;
                        text = j.ToString();
                    }
                    string text2 = text;
                    for (int j = 0; j < text2.Length; j++)
                    {
                        if (!char.IsDigit(text2[j]))
                        {
                            return;
                        }
                    }
                    APIUser apiuser = PlayerManager.GetPlayer(int.Parse(text)).GetAPIUser();
                    PlayerManager.GetPlayer(int.Parse(text));
                    Renderer[] componentsInChildren = gameObject.GetComponentsInChildren<Renderer>(true);
                    if (apiuser.id != APIUser.CurrentUser.id)
                    {
                        foreach (Renderer renderer in componentsInChildren)
                        {
                            if (renderer.materials == null)
                            {
                                return;
                            }
                            foreach (Material material in renderer.materials)
                            {
                                foreach (string value in GeneralUtils.BlacklistedShaders)
                                {
                                    if (material.shader.name.ToLower().Contains(value.ToLower()))
                                    {

                                        material.shader = Shader.Find("Standard");
                                        if (!AntiCrash.removedCrash.ContainsKey(apiuser.id))
                                        {
                                            AntiCrash.removedCrash.Add(apiuser.id, DateTime.Now);
                                        }
                                    }
                                }
                            }
                        }
                        foreach (ParticleSystem particleSystem in gameObject.GetComponentsInChildren<ParticleSystem>(true))
                        {
                            if (particleSystem.GetComponent<ParticleSystemRenderer>())
                            {
                                if (particleSystem.main.maxParticles >= 10000)
                                {

                                    particleSystem.Stop(true);
                                    //particleSystem.main.maxParticles = 0;
                                    particleSystem.GetComponent<ParticleSystemRenderer>().enabled = false;
                                    if (!AntiCrash.removedCrash.ContainsKey(apiuser.id))
                                    {
                                        AntiCrash.removedCrash.Add(apiuser.id, DateTime.Now);
                                    }
                                }
                                if (particleSystem.emission.rateOverTimeMultiplier >= 10000f)
                                {
                                    particleSystem.Stop(true);
                                    //particleSystem.main.maxParticles = 0;
                                    //particleSystem.emission.rateOverTimeMultiplier = 0f;
                                    particleSystem.GetComponent<ParticleSystemRenderer>().enabled = false;
                                    if (!AntiCrash.removedCrash.ContainsKey(apiuser.id))
                                    {
                                        AntiCrash.removedCrash.Add(apiuser.id, DateTime.Now);
                                    }
                                }
                                if (particleSystem.emission.rateOverDistanceMultiplier >= 10000f)
                                {
                                    particleSystem.Stop(true);
                                    //particleSystem.main.maxParticles = 0;
                                    //particleSystem.emission.rateOverDistanceMultiplier = 0f;
                                    particleSystem.GetComponent<ParticleSystemRenderer>().enabled = false;
                                    if (!AntiCrash.removedCrash.ContainsKey(apiuser.id))
                                    {
                                        AntiCrash.removedCrash.Add(apiuser.id, DateTime.Now);
                                    }
                                }
                                if (particleSystem.collision.maxCollisionShapes >= 1000)
                                {
                                    particleSystem.Stop(true);
                                    //particleSystem.main.maxParticles = 0;
                                    //particleSystem.collision.maxCollisionShapes = 0;
                                    particleSystem.GetComponent<ParticleSystemRenderer>().enabled = false;
                                    if (!AntiCrash.removedCrash.ContainsKey(apiuser.id))
                                    {
                                        AntiCrash.removedCrash.Add(apiuser.id, DateTime.Now);
                                    }
                                }
                            }
                        }
                        SkinnedMeshRenderer[] componentsInChildren3 = gameObject.GetComponentsInChildren<SkinnedMeshRenderer>(true);
                        int num = 0;
                        int num2 = 0;
                        int num3 = 0;
                        int num4 = 0;
                        int num5 = 0;
                        int num6 = 0;
                        foreach (SkinnedMeshRenderer skinnedMeshRenderer in componentsInChildren3)
                        {
                            int vertexCount = skinnedMeshRenderer.sharedMesh.vertexCount;
                            int num7 = skinnedMeshRenderer.sharedMesh.triangles.Length / 3;
                            int subMeshCount = skinnedMeshRenderer.sharedMesh.subMeshCount;
                            string name = skinnedMeshRenderer.name;
                            if (vertexCount > 100000)
                            {
                                UnityEngine.Object.Destroy(skinnedMeshRenderer);
                                num++;
                                num2 += vertexCount;
                                if (!AntiCrash.removedMesh.ContainsKey(apiuser.id))
                                {
                                    AntiCrash.removedMesh.Add(apiuser.id, DateTime.Now);
                                }
                            }
                            if (num7 > 200000)
                            {
                                UnityEngine.Object.Destroy(skinnedMeshRenderer);
                                num3++;
                                num4 += num7;
                                if (!AntiCrash.removedMesh.ContainsKey(apiuser.id))
                                {
                                    AntiCrash.removedMesh.Add(apiuser.id, DateTime.Now);
                                }
                            }
                            if (subMeshCount > 50)
                            {
                                UnityEngine.Object.Destroy(skinnedMeshRenderer);
                                num5++;
                                num6 += subMeshCount;
                                if (!AntiCrash.removedMesh.ContainsKey(apiuser.id))
                                {
                                    AntiCrash.removedMesh.Add(apiuser.id, DateTime.Now);
                                }
                            }
                        }
                       
                       
                        MeshFilter[] componentsInChildren4 = gameObject.GetComponentsInChildren<MeshFilter>(true);
                        int num8 = 0;
                        int num9 = 0;
                        int num10 = 0;
                        int num11 = 0;
                        int num12 = 0;
                        int num13 = 0;
                        foreach (MeshFilter meshFilter in componentsInChildren4)
                        {
                            int vertexCount2 = meshFilter.sharedMesh.vertexCount;
                            int subMeshCount2 = meshFilter.sharedMesh.subMeshCount;
                            int num14 = meshFilter.sharedMesh.triangles.Length / 3;
                            string name2 = meshFilter.sharedMesh.name;
                            if (vertexCount2 < 10 && num14 > 5000)
                            {
                                UnityEngine.Object.Destroy(meshFilter);
                                if (!AntiCrash.removedMesh.ContainsKey(apiuser.id))
                                {
                                    AntiCrash.removedMesh.Add(apiuser.id, DateTime.Now);
                                }
                            }
                            if (vertexCount2 >= 67000)
                            {
                                UnityEngine.Object.Destroy(meshFilter);
                                num8++;
                                num9 += vertexCount2;
                                if (!AntiCrash.removedMesh.ContainsKey(apiuser.id))
                                {
                                    AntiCrash.removedMesh.Add(apiuser.id, DateTime.Now);
                                }
                            }
                            if (subMeshCount2 >= 100)
                            {
                                UnityEngine.Object.Destroy(meshFilter);
                                num10++;
                                num11 += subMeshCount2;
                                if (!AntiCrash.removedMesh.ContainsKey(apiuser.id))
                                {
                                    AntiCrash.removedMesh.Add(apiuser.id, DateTime.Now);
                                }
                            }
                            if (num14 >= 100000)
                            {
                                UnityEngine.Object.Destroy(meshFilter);
                                num12++;
                                num13 += num14;
                                if (!AntiCrash.removedMesh.ContainsKey(apiuser.id))
                                {
                                    AntiCrash.removedMesh.Add(apiuser.id, DateTime.Now);
                                }
                            }
                        }
                       
                    }
                }
            }
        }

        // Token: 0x06001A4F RID: 6735 RVA: 0x00035C18 File Offset: 0x00033E18
        private static int returnPolys(GameObject player, string goName)
        {
            return CountPolygons(player.GetComponentsInChildren<Renderer>(true).FirstOrDefault((Renderer x) => x.name.ToLower().Contains(goName.ToLower())));
        }
        internal static int CountPolygons(Renderer r)
        {
            int num = 0;
            SkinnedMeshRenderer skinnedMeshRenderer = r as SkinnedMeshRenderer;
            if (skinnedMeshRenderer != null)
            {
                if (skinnedMeshRenderer.sharedMesh == null)
                {
                    return 0;
                }
                num += CountMeshPolys(skinnedMeshRenderer.sharedMesh);
            }
            MeshRenderer meshRenderer = r as MeshRenderer;
            if (meshRenderer != null)
            {
                MeshFilter component = meshRenderer.GetComponent<MeshFilter>();
                if (component == null || component.sharedMesh == null)
                {
                    return 0;
                }
                num += CountMeshPolys(component.sharedMesh);
            }
            return num;
        }

        private static int CountMeshPolys(Mesh sourceMesh)
        {
            bool flag = false;
            Mesh mesh;
            if (sourceMesh.isReadable)
            {
                mesh = sourceMesh;
            }
            else
            {
                mesh = UnityEngine.Object.Instantiate<Mesh>(sourceMesh);
                flag = true;
            }
            int num = 0;
            for (int i = 0; i < mesh.subMeshCount; i++)
            {
                num += mesh.GetTriangles(i).Length / 3;
            }
            if (flag)
            {
                UnityEngine.Object.Destroy(mesh);
            }
            return num;
        }


        // Token: 0x04000BF3 RID: 3059
        private static AntiCrash instance;

        // Token: 0x04000BF4 RID: 3060
        internal static Dictionary<string, DateTime> removedCrash = new Dictionary<string, DateTime>();

        // Token: 0x04000BF5 RID: 3061
        internal static Dictionary<string, DateTime> removedMesh = new Dictionary<string, DateTime>();
        private static IEnumerable<string> removedShaders;
    }
}
