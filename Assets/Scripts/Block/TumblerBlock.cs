using System;
using UnityEngine;

public class TumblerBlock : ABlock
{
    private int groupId;

    public int GroupId => groupId;

    public TumblerBlock(int id, int group, GameObject blockObject, GridElement gridElement) : base(id, blockObject, gridElement)
    {
        isMovable = true;
        groupId = group;

        gridElement.SetInaccessible();

        SetActive(true);
    }

    public override void ChangePoint(GridElement newElement)
    {
        gridElement = newElement;
    }

    public override void TransitTransform()
    {
        isInTransit = true;
    }

    public override void FinalTransform()
    {
        isInTransit = false;
    }

    public void StartStoneMatchEffects()
    {
        SetActive(false);
    }

    private void SetActive(bool value)
    {
        Debug.LogError($"Inscription Block -> SetActive : {value}");
    }
}

