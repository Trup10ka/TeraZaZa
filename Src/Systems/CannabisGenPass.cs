using TeraZaZa.Tile;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.WorldBuilding;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Systems;

public class CannabisGenPass : GenPass
{
    public CannabisGenPass(string name, double loadWeight) : base(name, loadWeight)
    {
    }

    protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
    {
        progress.Message = "Generating Cannabis";

        var maxToSpawn = (int) (Main.maxTilesX * Main.maxTilesY * 0.05);
        for (var i = 0; i < maxToSpawn; i++)
        {
            var x = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
            var y = WorldGen.genRand.Next((int) Main.worldSurface - 250, Main.maxTilesY - 900);

            var tile = Framing.GetTileSafely(x, y);
            if (tile.TileType == TileID.Grass)
                WorldGen.PlaceTile(x, y - 1, TileType<WhiteWidowCannabis>());
        }
    }
}