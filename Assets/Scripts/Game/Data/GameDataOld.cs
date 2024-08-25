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
    public List<Vector2> PawnBlocksPositions;
    public List<Vector2> PawnTargetBlocksPositions;
    public List<Vector2> TumblerBlocksPositions;
    public List<Vector2> TumblerTargetBlocksPositions;

    public GameDataOld()
    {
        this.Id = 0;
        this.Level = null;
        this.Name = null;

        this.PlayerPosition = Vector2.zero;
        this.MobileBlocksPositions = new List<Vector2>();
        this.StaticBlocksPositions = new List<Vector2>();
        this.PawnBlocksPositions = new List<Vector2>();
        this.PawnTargetBlocksPositions = new List<Vector2>();
        this.TumblerBlocksPositions = new List<Vector2>();
        this.TumblerTargetBlocksPositions = new List<Vector2>();
    }
}

