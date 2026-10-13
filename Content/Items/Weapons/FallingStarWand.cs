using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarforgedWeapons.Content.Items.Weapons
{
    public class FallingStarWand : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 26;
            Item.knockBack = 4.0f;
            Item.useTime = 28;
            Item.useAnimation = 28;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.value = Item.buyPrice(gold: 1, silver: 20);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item20;
            Item.DamageType = DamageClass.Magic;
            Item.mana = 8;
            Item.shoot = ProjectileID.DiamondBolt;
            Item.shootSpeed = 9.0f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MeteoriteBar, 12);
            recipe.AddRecipeGroup("StarforgedWeapons:EvilBar", 6); // Demonite or Crimtane bar
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.DemonAltar);
            recipe.Register();
        }
    }
}
