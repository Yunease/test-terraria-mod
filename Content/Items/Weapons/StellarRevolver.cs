using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarforgedWeapons.Content.Items.Weapons
{
    public class StellarRevolver : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 38;
            Item.knockBack = 4.5f;
            Item.useTime = 18;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.value = Item.buyPrice(gold: 2, silver: 50);
            Item.rare = ItemRarityID.Pink;
            Item.UseSound = SoundID.Item11;
            Item.DamageType = DamageClass.Ranged;
            Item.useAmmo = AmmoID.Bullet;
            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 12.0f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HallowedBar, 8);
            recipe.AddIngredient(ItemID.MeteoriteBar, 6);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
