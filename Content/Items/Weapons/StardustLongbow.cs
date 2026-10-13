using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarforgedWeapons.Content.Items.Weapons
{
    public class StardustLongbow : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 18;
            Item.knockBack = 2.0f;
            Item.useTime = 26;
            Item.useAnimation = 26;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.value = Item.buyPrice(silver: 80);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item5;
            Item.DamageType = DamageClass.Ranged;
            Item.useAmmo = AmmoID.Arrow;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.shootSpeed = 8.5f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MeteoriteBar, 8);
            recipe.AddIngredient(ItemID.FallenStar, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
