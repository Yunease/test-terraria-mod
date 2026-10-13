using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarforgedWeapons.Content.Items.Weapons
{
    public class StarShardDagger : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 12;
            Item.knockBack = 3.5f;
            Item.useTime = 14;
            Item.useAnimation = 14;
            Item.useStyle = ItemUseStyleID.Thrust;
            Item.autoReuse = true;
            Item.value = Item.buyPrice(silver: 40);
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item1;
            Item.DamageType = DamageClass.Melee;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IronBar, 6);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
