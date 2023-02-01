using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace EFRecipes.Patches {
    public static class HarmonyPatches {


        [HarmonyPatch(typeof(BlockEntityTrough), "OnInteract")]
        public static class Trough_NoWaxMash {

            public static Lazy<AssetLocation> lzHoneyMash = new Lazy<AssetLocation>(() => new AssetLocation("game", "pressedmash-honey"));

            /// <summary>
            /// Blocks adding pressed honeycomb mash to troughs via item code
            /// </summary>
            /// <remarks>
            /// Tried doing this via json patching (add 'contentConfig' element specific to honeymash to trough). 
            /// Even if that worked, it would <em>still</em> allow to just stick wax into a trough even if no animal ate it.
            /// This way you just cannot put pressed honey mash into a trough.
            /// </remarks>
            [HarmonyPrefix]                     
            public static bool BlockHoneyMash(IPlayer byPlayer, ref bool __result) {
                // one of the few times a prefix is justified. We check for a condition and if true, suppress all the basic interaction logic

                ItemSlot handSlot = byPlayer.InventoryManager.ActiveHotbarSlot;

                if (!handSlot.Empty && handSlot.Itemstack.Item.Code == lzHoneyMash.Value) {
                    __result = false;
                    return false;
                }

                return true;
            }
        }
    }
}
