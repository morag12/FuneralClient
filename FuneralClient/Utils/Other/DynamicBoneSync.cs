using System;
using UnityEngine;
using VRC;
using VRCSDK2;

namespace Funeral
{
    internal class DynamicBoneSync : MonoBehaviour
    {
        internal void Start()
        {
            this.player = base.GetComponent<VRC.Player>();
            if (this.player == null) return;
            VRCAvatarManager vrcavatarManager = this.player.vrcPlayer.HOIHOKEHFGC;
        }

        internal void OnEnable()
        {
            //todo
        }

        internal void OnDisable()
        {
            if (this.player != PlayerManager.GetCurrentPlayer())
            {
                this.bones = new DynamicBone[0];
                this.colliders = new DynamicBoneCollider[0];
            }
            this.active = false;
        }

        internal void OnDestroy()
        {
            GlobalDynamicBones.OnPlayerDelete(this);
        }

        internal void OnUpdateDynamics()
        {
            this.player = base.GetComponent<VRC.Player>();
            if (this.player == null)
            {
                return;
            }
            if (!(this.player != PlayerManager.GetCurrentPlayer()))
            {
                GlobalDynamicBones.OnUpdateDynamics();
                return;
            }
            GlobalDynamicBones.RemoveColliders(GlobalDynamicBones.myBones, this.colliders);
            this.bones = base.GetComponentsInChildren<DynamicBone>(true);
            this.colliders = GlobalDynamicBones.GetHandColliders(this.player.vrcPlayer);
            this.active = false;
        }

        internal DynamicBone[] bones = new DynamicBone[0];

        internal DynamicBoneCollider[] colliders = new DynamicBoneCollider[0];

        internal bool active;

        private VRC.Player player;
    }
}
