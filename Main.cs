using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using VRC;
using VRC.SDK3.Components;

namespace BetterDJ
{
    public class Main : MelonMod
    {
        public static VRC.Player player;
        public VRCSpatialAudioSource spatialSource;
        public static MelonPreferences_Category BetterDJCategory;
        public static MelonPreferences_Entry<bool> BetterDJEntry;
        public AudioClip clip;
        public override void OnApplicationStart()
        {
            MelonPreferences.CreateCategory("BetterDJ");
            BetterDJEntry = BetterDJCategory.CreateEntry("BetterDJEntryText", false);
        }
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                PlayAudioClip();
            }
        }
        public void PlayAudioClip() 
        {
            var player = VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCAvatarManager_0.prop_GameObject_0;
            var audioComponent = player.GetComponentsInChildren<VRCSpatialAudioSource>(true);
            foreach (var audioSource in audioComponent)
            {
                if (audioSource != null)
                { 
                    // Do this stuff
                }
            }
        }
    }
}
