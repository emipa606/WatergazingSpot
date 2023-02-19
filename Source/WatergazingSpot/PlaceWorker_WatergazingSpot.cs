using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace WatergazingSpot;

public class PlaceWorker_WatergazingSpot : PlaceWorker
{
    public override void DrawGhost(ThingDef def, IntVec3 center, Rot4 rot, Color ghostCol, Thing thing = null)
    {
        GenDraw.DrawFieldEdges(new List<IntVec3> { center + IntVec3.South.RotatedBy(rot) });
    }

    public override AcceptanceReport AllowsPlacing(BuildableDef checkingDef, IntVec3 loc, Rot4 rot, Map map,
        Thing thingToIgnore = null, Thing thing = null)
    {
        var lookingSpot = loc + IntVec3.South.RotatedBy(rot);
        if (!lookingSpot.InBounds(map) || !loc.InBounds(map))
        {
            return new AcceptanceReport("OutOfBounds".Translate());
        }

        var lookingSpotTerrain = map.terrainGrid.TerrainAt(lookingSpot);
        if (!lookingSpotTerrain.defName.Contains("Water") && !lookingSpotTerrain.defName.Contains("Marsh"))
        {
            return new AcceptanceReport("WatergazingSpot.OnWater".Translate());
        }

        var standingSpotTerrain = map.terrainGrid.TerrainAt(loc);
        if (!standingSpotTerrain.defName.Contains("Water") && !standingSpotTerrain.defName.Contains("Marsh"))
        {
            return true;
        }

        if (standingSpotTerrain.defName.Contains("Bridge"))
        {
            return true;
        }

        return new AcceptanceReport("WatergazingSpot.OnBridge".Translate());
    }
}