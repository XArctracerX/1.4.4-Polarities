﻿using Microsoft.Xna.Framework;
using Polarities.Dusts;
using Polarities.Items.Placeable.Blocks.Fractal;
using Terraria.ID;
using Terraria.ModLoader;

namespace Polarities.Items.Placeable.Furniture.Fractal
{
    public class FractalTorch : TorchBase
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 100;

            ItemID.Sets.WaterTorches[Type] = true;
        }

        public override int PlaceTile => ModContent.TileType<FractalTorchTile>();

        public override void AddRecipes()
        {
            CreateRecipe(3)
                .AddIngredient(ItemID.Torch, 3)
                .AddIngredient<FractalMatter>()
                .Register();
        }
    }

    public class FractalTorchTile : TorchTileBase
    {
        public override Color LightColor => new(181, 248, 255);
        public override bool Flame => true;
        public override int MyDustType => ModContent.DustType<FractalMatterDust>();
        public override int DropItem => ModContent.ItemType<FractalTorch>();
        public override bool DieInWater => false;
    }
}