using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace StarforgedWeapons
{
    public class StarforgedWeapons : Mod
    {
        public override void AddRecipeGroups()
        {
            // Group for Demonite Bar or Crimtane Bar
            RecipeGroup evilBarGroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Lang.GetItemName(ItemID.DemoniteBar).Value,
                ItemID.DemoniteBar, ItemID.CrimtaneBar);
            RecipeGroup.Register("StarforgedWeapons:EvilBar", evilBarGroup);
        }
    }
}
