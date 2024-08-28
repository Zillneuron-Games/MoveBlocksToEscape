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
    public List<Vector3> PawnBlocksPositions;
    public List<Vector3> PawnTargetBlocksPositions;
    public List<Vector3> TumblerBlocksPositions;
    public List<Vector3> TumblerTargetBlocksPositions;

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

    public GameData(int id, string level, string name, Vector2 playerPosition, List<Vector2> mobileBlocksPositions, List<Vector2> staticBlocksositions, List<Vector3> pawnBlocksPositions, List<Vector3> pawnTargetBlocksPositions, List<Vector3> tumblerBlocksPositions, List<Vector3> tumblerTargetBlocksPositions)
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

