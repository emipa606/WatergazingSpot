using RimWorld;
using Verse;

namespace WatergazingSpot;

public class JobDriver_WaterGazing : JobDriver_WatchBuilding
{
    protected override void WatchTickAction(int delta)
    {
        pawn.rotationTracker.FaceCell(TargetA.Cell + IntVec3.South.RotatedBy(TargetA.Thing.Rotation));
        pawn.GainComfortFromCellIfPossible(delta);
        JoyUtility.JoyTickCheckEnd(pawn, delta, JoyTickFullJoyAction.EndJob, 1f, (Building)TargetThingA);
    }
}