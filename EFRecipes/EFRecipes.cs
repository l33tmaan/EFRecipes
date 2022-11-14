using ACulinaryArtillery;
using ACulinaryArtillery.Util;
using System;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Vintagestory.API.Server;
using Vintagestory.GameContent;

namespace EFRecipes
{
    public class EFRecipes : ModSystem
    {
            public override void Start(ICoreAPI api)
		{
			base.Start(api);

			CookingRecipe.NamingRegistry["compote"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["augratin"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["riceandbeans"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["meatysalad"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["yogurtmeal"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["pastahot"] = new acaRecipeNames();
            CookingRecipe.NamingRegistry["pastacold"] = new acaRecipeNames();
		}
	}
}
