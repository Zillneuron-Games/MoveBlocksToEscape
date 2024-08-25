using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameData
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

    public GameData()
    {
        Id = 0;
        Level = null;
        Name = null;

        PlayerPosition = new Vector2();
        MobileBlocksPositions = null;
        StaticBlocksPositions = null;
        PawnBlocksPositions = null;
        PawnTargetBlocksPositions = null;
        TumblerBlocksPositions = null;
        TumblerTargetBlocksPositions = null;
    }

    public GameData(int id, string level, string name, Vector2 playerPosition, List<Vector2> mobileBlocksPositions, List<Vector2> staticBlocksositions, List<Vector2> pawnBlocksPositions, List<Vector2> pawnTargetBlocksPositions, List<Vector2> tumblerBlocksPositions, List<Vector2> tumblerTargetBlocksPositions)
    {
        Id = id;
        Level = level;
        Name = name;

        PlayerPosition = playerPosition;
        MobileBlocksPositions = mobileBlocksPositions;
        StaticBlocksPositions = staticBlocksositions;
        PawnBlocksPositions = pawnBlocksPositions;
        PawnTargetBlocksPositions = pawnTargetBlocksPositions;
        TumblerBlocksPositions = tumblerBlocksPositions;
        TumblerTargetBlocksPositions = tumblerTargetBlocksPositions;
    }
}

