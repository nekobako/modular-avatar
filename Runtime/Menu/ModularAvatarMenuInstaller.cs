﻿using UnityEngine;
using VRC.SDK3.Avatars.ScriptableObjects;

namespace nadena.dev.modular_avatar.core
{
    [AddComponentMenu("Modular Avatar/MA Menu Installer")]
    [HelpURL("https://modular-avatar.nadena.dev/docs/reference/menu-installer?lang=auto")]
    public class ModularAvatarMenuInstaller : AvatarTagComponent
    {
        public VRCExpressionsMenu menuToAppend;
        public VRCExpressionsMenu installTargetMenu;


        // ReSharper disable once Unity.RedundantEventFunction
        void Start()
        {
            // Ensure that unity generates an enable checkbox
        }

        protected override void OnValidate()
        {
            base.OnValidate();

            RuntimeUtil.InvalidateMenu();
        }

        public override void ResolveReferences()
        {
            // no-op
        }
    }
}