using System;
using UnityEngine;

public class PawnTargetBlock : ABlock
{
    private int groupId;

    public int GroupId => groupId;

    public PawnTargetBlock(int id, int group, GameObject blockObject, GridElement gridElement) : base(id, blockObject, gridElement)
    {
        isMovable = false;
        groupId = group;
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
