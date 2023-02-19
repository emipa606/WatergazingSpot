using Verse;

namespace WatergazingSpot;

public class WatergazingSpot : Building
{
    public override void TickRare()
    {
        base.TickRare();
        var lookingSpotTerrain = Map.terrainGrid.TerrainAt(Position + IntVec3.South.RotatedBy(Rotation));
        if (!lookingSpotTerrain.defName.Contains("Water") && !lookingSpotTerrain.defName.Contains("Marsh") &&
            !lookingSpotTerrain.defName.Contains("Ice"))
        {
            Destroy();
            return;
        }

        var standingSpotTerrain = Map.terrainGrid.TerrainAt(Position);
        if (!standingSpotTerrain.defName.Contains("Water") && !standingSpotTerrain.defName.Contains("Marsh"))
        {
            return;
        }

        if (!standingSpotTerrain.defName.Contains("Bridge"))
        {
            Destroy();
        }
    }
}