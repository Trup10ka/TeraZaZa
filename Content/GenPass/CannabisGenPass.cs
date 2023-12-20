using TeraZaZa.Content.Tile.Cannabis;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.WorldBuilding;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Content.GenPass;

public class CannabisGenPass : Terraria.WorldBuilding.GenPass
{
    public CannabisGenPass(string name, double loadWeight) : base(name, loadWeight)
    {
    }

    protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
    {
        progress.Message = "Generating Cannabis";

        var maxToSpawn = (int) (Main.maxTilesX * Main.maxTilesY * 0.004);
        for (var i = 0; i < maxToSpawn; i++)
            TryToPlaceCannabis();
    }

    private static void TryToPlaceCannabis()
    {
        var x = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
        var y = WorldGen.genRand.Next((int) (Main.worldSurface * 0.35), (int) Main.worldSurface);

        var tile = Framing.GetTileSafely(x, y);

        if (!IsNotUnderGround(x, y)) return;
        switch (tile.TileType)
        {
            case TileID.Grass: WorldGen.PlaceTile(x, y - 1, TileType<SuperSilverHazeCannabis>());
                break;
            case TileID.CorruptGrass: WorldGen.PlaceTile(x, y - 1, TileType<MauiWowieCannabis>());
                break;
        }
    }
    
    private static bool IsNotUnderGround(int x, int y)
    {
        var leftTop = Framing.GetTileSafely(x - 1, y - 1);
        var rightTop = Framing.GetTileSafely(x + 1, y - 1);
        var middleTop = Framing.GetTileSafely(x, y - 1);
        return !middleTop.HasTile && !leftTop.HasTile && !rightTop.HasTile;
    }
}