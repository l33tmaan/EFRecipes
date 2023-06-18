using ACulinaryArtillery;
using ACulinaryArtillery.Util;
using HarmonyLib;
using System;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Vintagestory.API.Server;
using Vintagestory.GameContent;

namespace EFRecipes
{
    public class EFRecipes : ModSystem
      {
        /* Harmony _harmony;

        public override void Start(ICoreAPI api)
		 {
            _harmony = new Harmony("ExpandedFoods.Patches");
            _harmony.PatchAll(typeof(EFRecipes).Assembly);

			CookingRecipe.NamingRegistry["compote"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["augratin"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["riceandbeans"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["meatysalad"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["yogurtmeal"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["pastahot"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["pastacold"] = new acaRecipeNames();
		} 

        public override void Dispose() {
            base.Dispose();
            _harmony.UnpatchAll();
        } */
    } 
}
