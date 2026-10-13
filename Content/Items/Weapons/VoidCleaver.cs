using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarforgedWeapons.Content.Items.Weapons
{
    public class VoidCleaver : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 72;
            Item.knockBack = 6.0f;
            Item.useTime = 22;
            Item.useAnimation = 22;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.autoReuse = true;
            Item.value = Item.buyPrice(gold: 8, silver: 50);
            Item.rare = ItemRarityID.Yellow;
            Item.UseSound = SoundID.Item1;
            Item.DamageType = DamageClass.Melee;
            Item.shoot = ProjectileID.TerraBeam;
            Item.shootSpeed = 12.0f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
            recipe.AddIngredient(ItemID.SoulofMight, 8);
            recipe.AddIngredient(ItemID.LunarBar, 4);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}
