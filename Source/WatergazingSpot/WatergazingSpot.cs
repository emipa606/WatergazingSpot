using Verse;

namespace WatergazingSpot;

public class WatergazingSpot : Building
{
    public override void TickRare()
    {
        base.TickRare();
        var lookingSpotTerrain = Map.terrainGrid.TerrainAt(Position + IntVec3.South.RotatedBy(Rotation));
        if (!lookingSpotTerrain.IsWater && !lookingSpotTerrain.IsIce)
        {
            Destroy();
            return;
        }

        var standingSpotTerrain = Map.terrainGrid.TerrainAt(Position);
        if (!standingSpotTerrain.IsWater || standingSpotTerrain.defName.Contains("Bridge"))
        {
            return;
        }

        Destroy();
    }
}