using UnityEngine;
using System.Collections.Generic;
using System;

[Serializable]
public class GameDataOld
{
    public int Id;
    public string Level;
    public string Name;

    public Vector2 PlayerPosition;
    public List<Vector2> MobileBlocksPositions;
    public List<Vector2> StaticBlocksPositions;
    public List<Vector3> PawnBlocksPositions;
    public List<Vector3> PawnTargetBlocksPositions;
    public List<Vector3> TumblerBlocksPositions;
    public List<Vector3> TumblerTargetBlocksPositions;

    public GameDataOld()
    {
        this.Id = 0;
        this.Level = null;
        this.Name = null;

        this.PlayerPosition = Vector2.zero;
        this.MobileBlocksPositions = new List<Vector2>();
        this.StaticBlocksPositions = new List<Vector2>();
        this.PawnBlocksPositions = new List<Vector3>();
        this.PawnTargetBlocksPositions = new List<Vector3>();
        this.TumblerBlocksPositions = new List<Vector3>();
        this.TumblerTargetBlocksPositions = new List<Vector3>();
    }
}

