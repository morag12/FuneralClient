using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using VRC;

namespace Funeral
{
    internal class GlobalDynamicBones : MonoBehaviour
    {
        internal static GlobalDynamicBones Instance { get; private set; }

        internal static DynamicBone[] myBones = new DynamicBone[0];

        internal static DynamicBoneCollider[] myColliders = new DynamicBoneCollider[0];

        internal static List<DynamicBoneSync> dynamicBones = new List<DynamicBoneSync>();

        internal static bool includeAllBones = true;

        internal static float updateTime = 1f;

        internal static float maxDistance = 2f;

        private static FieldInfo bound_f;

        private static float timeToUpdate = 0f;

        static GlobalDynamicBones()
        {
            GlobalDynamicBones.bound_f = typeof(DynamicBoneCollider).GetField("m_Bound");
        }

        private void Awake()
        {
            if (GlobalDynamicBones.Instance == null)
            {
                GlobalDynamicBones.Instance = this;
                return;
            }
        }

        private void OnEnable()
        {
            if (PlayerManager.GetAllPlayers() != null)
            {
               Player[] allPlayers = PlayerManager.GetAllPlayers();
           GlobalDynamicBones.dynamicBones = new List<DynamicBoneSync>(allPlayers.Length);
            foreach (Player player in allPlayers)
            {
                    DynamicBoneSync component = player.GetComponent<DynamicBoneSync>();
                    if (component != null)
                   {
                       Debug.Log("DynamicBoneSync toggle on: " + player.name);
                        component.enabled = true;
                       component.OnUpdateDynamics();
                       if (player != PlayerManager.GetCurrentPlayer())
                       {
                           GlobalDynamicBones.dynamicBones.Add(component);
                        }
                    }
                    else
                    {
                        GlobalDynamicBones.OnPlayerAdd(player);
                    }
                }
            }
        }

        private void Update()
        {
            if (RoomManagerBase.currentRoom == null || PlayerManager.GetCurrentPlayer() == null)
            {
                return;
            }
            GlobalDynamicBones.timeToUpdate -= Time.deltaTime;
            if (GlobalDynamicBones.timeToUpdate > 0f)
            {
                return;
            }
            GlobalDynamicBones.timeToUpdate = GlobalDynamicBones.updateTime;
            Player player = PlayerManager.GetCurrentPlayer();
            if (player == null)
            {
                return;
            }
            if (player.vrcPlayer == null)
            {
                return;
            }
            if (player.vrcPlayer.avatarGameObject == null)
            {
                return;
            }
            Vector3 position = player.vrcPlayer.avatarGameObject.transform.position;
            float num = GlobalDynamicBones.maxDistance * GlobalDynamicBones.maxDistance;
            foreach (DynamicBoneSync dynamicBoneSync in GlobalDynamicBones.dynamicBones)
            {
                if ((dynamicBoneSync.transform.position - position).sqrMagnitude < num)
                {
                    if (!dynamicBoneSync.active)
                    {
                        dynamicBoneSync.active = true;
                        GlobalDynamicBones.ApplyColliders(dynamicBoneSync.bones, GlobalDynamicBones.myColliders);
                        GlobalDynamicBones.ApplyColliders(GlobalDynamicBones.myBones, dynamicBoneSync.colliders);
                    }
                }
                else if (dynamicBoneSync.active)
                {
                    dynamicBoneSync.active = false;
                    GlobalDynamicBones.RemoveColliders(dynamicBoneSync.bones, GlobalDynamicBones.myColliders);
                    GlobalDynamicBones.RemoveColliders(GlobalDynamicBones.myBones, dynamicBoneSync.colliders);
                }
            }
        }

        private void OnDisable()
        {
            //todo
        }

        private void OnDestroy()
        {
            if (GlobalDynamicBones.Instance == this)
            {
                GlobalDynamicBones.Instance = null;
            }
        }

        private static void OnPlayerAdd(Player player)
        {
            if (player != PlayerManager.GetCurrentPlayer())
            {
                GlobalDynamicBones.dynamicBones.Add(player.gameObject.AddComponent<DynamicBoneSync>());
                return;
            }
            player.gameObject.AddComponent<DynamicBoneSync>();
        }

        internal static void OnPlayerDelete(DynamicBoneSync dynamic)
        {
            if (dynamic == null)
            {
                Debug.Log("DynamicBoneSync is null !!!");
                return;
            }
            Player component = dynamic.GetComponent<Player>();
            if (component == null)
            {
                Debug.Log("DynamicBoneSync: player is null !!!");
            }
            if (!(component != PlayerManager.GetCurrentPlayer()))
            {
                GlobalDynamicBones.myBones = new DynamicBone[0];
                GlobalDynamicBones.myColliders = new DynamicBoneCollider[0];
                return;
            }
            GlobalDynamicBones.dynamicBones.Remove(dynamic);
        }

        internal static void OnUpdateDynamics()
        {
            foreach (DynamicBoneSync dynamicBoneSync in GlobalDynamicBones.dynamicBones)
            {
                dynamicBoneSync.active = false;
            }
            GlobalDynamicBones.myColliders = GlobalDynamicBones.GetHandColliders(VRCPlayer.Instance);
            GlobalDynamicBones.myBones = VRCPlayer.Instance.GetComponentsInChildren<DynamicBone>(true);
            Debug.Log(string.Format("DynamicBoneSync: MyDynamicBones: {0} + MyColliders: {1}", GlobalDynamicBones.myBones.Length, GlobalDynamicBones.myColliders.Length));
        }

        internal static DynamicBoneCollider[] GetHandColliders(VRCPlayer avatar)
        {
            if (avatar.avatarAnimator == null)
            {
                return new DynamicBoneCollider[0];
            }
            Transform boneTransform = avatar.avatarAnimator.GetBoneTransform(HumanBodyBones.LeftHand);
            DynamicBoneCollider[] array;
            if (boneTransform == null)
            {
                array = null;
            }
            else
            {
                DynamicBoneCollider[] componentsInChildren = boneTransform.GetComponentsInChildren<DynamicBoneCollider>(true);
                if (componentsInChildren == null)
                {
                    array = null;
                }
                else
                {
                    array = (from collider in componentsInChildren
                             where (int)GlobalDynamicBones.bound_f.GetValue(collider) == 0
                             select collider).ToArray<DynamicBoneCollider>();
                }
            }
            DynamicBoneCollider[] array2 = array;
            Transform boneTransform2 = avatar.avatarAnimator.GetBoneTransform(HumanBodyBones.RightHand);
            DynamicBoneCollider[] array3;
            if (boneTransform2 == null)
            {
                array3 = null;
            }
            else
            {
                DynamicBoneCollider[] componentsInChildren2 = boneTransform2.GetComponentsInChildren<DynamicBoneCollider>(true);
                if (componentsInChildren2 == null)
                {
                    array3 = null;
                }
                else
                {
                    array3 = (from collider in componentsInChildren2
                              where (int)GlobalDynamicBones.bound_f.GetValue(collider) == 0
                              select collider).ToArray<DynamicBoneCollider>();
                }
            }
            DynamicBoneCollider[] array4 = array3;
            if (array2 == null)
            {
                array2 = new DynamicBoneCollider[0];
            }
            if (array4 == null)
            {
                array4 = new DynamicBoneCollider[0];
            }
            return array2.Concat(array4).ToArray<DynamicBoneCollider>();
        }

        internal static DynamicBone[] GetCollidedBones(VRCPlayer avatar, DynamicBoneCollider[] colliders)
        {
            return (from bone in avatar.GetComponentsInChildren<DynamicBone>(true)
                    where bone.m_Colliders.Intersect(colliders).Count<DynamicBoneCollider>() != 0
                    select bone).ToArray<DynamicBone>();
        }

        internal static void ApplyColliders(DynamicBone[] bones, DynamicBoneCollider[] colliders)
        {
            for (int i = 0; i < bones.Length; i++)
            {
                bones[i].m_Colliders.AddRange(colliders);
            }
        }

        internal static void RemoveColliders(DynamicBone[] bones, DynamicBoneCollider[] colliders)
        {
            if (colliders.Length > 0)
            {
                //todo
            }
        }

    }
}
