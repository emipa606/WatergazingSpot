using RimWorld;
using Verse;

namespace WatergazingSpot;

public class JobDriver_WaterGazing : JobDriver_WatchBuilding
{
    protected override void WatchTickAction()
    {
        pawn.rotationTracker.FaceCell(TargetA.Cell + IntVec3.South.RotatedBy(TargetA.Thing.Rotation));
        pawn.GainComfortFromCellIfPossible();
        JoyUtility.JoyTickCheckEnd(pawn, JoyTickFullJoyAction.EndJob, 1f, (Building)TargetThingA);
    }
}