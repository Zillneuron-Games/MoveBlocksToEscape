using System;
using UnityEngine;

public class TumblerTargetBlock : ABlock
{
    public TumblerTargetBlock(int id, GameObject blockObject, GridElement gridElement) : base(id, blockObject, gridElement)
    {
        isMovable = false;
    }

    public override void ChangePoint(GridElement newElement)
    {

    }

    public override void TransitTransform()
    {

    }

    public override void FinalTransform()
    {

    }
}
