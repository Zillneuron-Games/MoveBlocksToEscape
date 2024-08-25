using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : AGame
{
    public Game(GameBoardGrid gameBoardGrid, int id, int stepsBest, int coinsBest, int playedNumber, PlayerBlock playerBlock, List<MobileBlock> mobileBlocks, List<StaticBlock> staticBlocks, List<PawnBlock> pawnBlocks, List<PawnTargetBlock> pawnTargetBlocks, List<TumblerBlock> tumblerBlocks, List<TumblerTargetBlock> tumblerTargetBlocks, Stack<GameplayStep> allMoves)
                        : base(gameBoardGrid, id, stepsBest, coinsBest, playedNumber, playerBlock, mobileBlocks, staticBlocks, pawnBlocks, pawnTargetBlocks, tumblerBlocks, tumblerTargetBlocks, allMoves)
    {
       
    }


    protected override void MoveUP()
    {
        bool isNewStepDone = false;

        List<ABlock> allMovableBlocks = new List<ABlock>();

        allMovableBlocks.Add(playerBlock);
        //allMovableBlocks.Add(inscriptionBlockBlue);
        //allMovableBlocks.Add(inscriptionBlockYellow);

        if (mobileBlocks != null && mobileBlocks.Count > 0)
        {
            foreach (MobileBlock block in mobileBlocks)
            {
                allMovableBlocks.Add(block);
            }
        }

        for (int i = 0; i < allMovableBlocks.Count; i++)
        {
            foreach (ABlock block in allMovableBlocks)
            {
                if (!block.IsInTransit)
                {
                    if (block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Top) != null && block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Top).State == EGridElementState.Empty)
                    {
                        block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Top).SetFull();
                        block.CurrentElement.SetEmpty();
                        block.ChangePoint(block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Top));
                        block.TransitTransform();

                        if (!isNewStepDone)
                        {
                            isNewStepDone = true;
                        }
                    }
                }
            }
        }


        if (isNewStepDone)
        {
            isNewStepDone = false;

            stepsCounter++;

            if (backStepsCounter < backStepsMaximum)
            {
                backStepsCounter++;
            }

            SortedDictionary<int, Vector2> allBlocksPositions = new SortedDictionary<int, Vector2>();

            foreach (ABlock block in allMovableBlocks)
            {
                block.FinalTransform();

                allBlocksPositions.Add(block.Id, block.CurrentElement.Position);
            }

            GameplayStep nextStep = new GameplayStep(allMoves.Count, EDirection.Up, allBlocksPositions);

            allMoves.Push(nextStep);

            SoundManager.Instance.PlayStoneMove();
            ThrowFinalTransformEvent();
        }
    }

    protected override void MoveDOWN()
    {
        bool isNewStepDone = false;

        List<ABlock> allMovableBlocks = new List<ABlock>();

        allMovableBlocks.Add(playerBlock);
        //allMovableBlocks.Add(inscriptionBlockBlue);
        //allMovableBlocks.Add(inscriptionBlockYellow);

        if (mobileBlocks != null && mobileBlocks.Count > 0)
        {
            foreach (MobileBlock block in mobileBlocks)
            {
                allMovableBlocks.Add(block);
            }
        }

        for (int i = 0; i < allMovableBlocks.Count; i++)
        {
            foreach (ABlock block in allMovableBlocks)
            {
                if (!block.IsInTransit)
                {
                    if (block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Bottom) != null && block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Bottom).State == EGridElementState.Empty)
                    {
                        block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Bottom).SetFull();
                        block.CurrentElement.SetEmpty();
                        block.ChangePoint(block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Bottom));
                        block.TransitTransform();

                        if (!isNewStepDone)
                        {
                            isNewStepDone = true;
                        }
                    }
                }
            }
        }


        if (isNewStepDone)
        {
            isNewStepDone = false;

            stepsCounter++;

            if (backStepsCounter < backStepsMaximum)
            {
                backStepsCounter++;
            }

            SortedDictionary<int, Vector2> allBlockPositions = new SortedDictionary<int, Vector2>();

            foreach (ABlock block in allMovableBlocks)
            {
                block.FinalTransform();

                allBlockPositions.Add(block.Id, block.CurrentElement.Position);
            }

            GameplayStep nextStep = new GameplayStep(allMoves.Count, EDirection.Down, allBlockPositions);

            allMoves.Push(nextStep);

            SoundManager.Instance.PlayStoneMove();
            ThrowFinalTransformEvent();
        }
    }

    protected override void MoveLEFT()
    {
        bool isNewStepDone = false;

        List<ABlock> allMovableBlocks = new List<ABlock>();

        allMovableBlocks.Add(playerBlock);
        //allMovableBlocks.Add(inscriptionBlockBlue);
        //allMovableBlocks.Add(inscriptionBlockYellow);

        if (mobileBlocks != null && mobileBlocks.Count > 0)
        {
            foreach (MobileBlock block in mobileBlocks)
            {
                allMovableBlocks.Add(block);
            }
        }

        for (int i = 0; i < allMovableBlocks.Count; i++)
        {
            foreach (ABlock block in allMovableBlocks)
            {
                if (!block.IsInTransit)
                {
                    if (block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Left) != null && block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Left).State == EGridElementState.Empty)
                    {
                        block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Left).SetFull();
                        block.CurrentElement.SetEmpty();
                        block.ChangePoint(block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Left));
                        block.TransitTransform();

                        if (!isNewStepDone)
                        {
                            isNewStepDone = true;
                        }
                    }
                }
            }
        }


        if (isNewStepDone)
        {
            isNewStepDone = false;

            stepsCounter++;

            if (backStepsCounter < backStepsMaximum)
            {
                backStepsCounter++;
            }

            SortedDictionary<int, Vector2> allBlocksPositions = new SortedDictionary<int, Vector2>();

            foreach (ABlock block in allMovableBlocks)
            {
                block.FinalTransform();

                allBlocksPositions.Add(block.Id, block.CurrentElement.Position);
            }

            GameplayStep nextStep = new GameplayStep(allMoves.Count, EDirection.Left, allBlocksPositions);

            allMoves.Push(nextStep);

            SoundManager.Instance.PlayStoneMove();
            ThrowFinalTransformEvent();
        }
    }

    protected override void MoveRIGHT()
    {
        bool isNewStepDone = false;

        List<ABlock> allMovableBlocks = new List<ABlock>();

        allMovableBlocks.Add(playerBlock);
        //allMovableBlocks.Add(inscriptionBlockBlue);
        //allMovableBlocks.Add(inscriptionBlockYellow);

        if (mobileBlocks != null && mobileBlocks.Count > 0)
        {
            foreach (MobileBlock block in mobileBlocks)
            {
                allMovableBlocks.Add(block);
            }
        }

        for (int i = 0; i < allMovableBlocks.Count; i++)
        {
            foreach (ABlock block in allMovableBlocks)
            {
                if (!block.IsInTransit)
                {
                    if (block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Right) != null && block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Right).State == EGridElementState.Empty)
                    {
                        block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Right).SetFull();
                        block.CurrentElement.SetEmpty();
                        block.ChangePoint(block.CurrentElement.GetReferencePoint(EGridElementNeighborSide.Right));
                        block.TransitTransform();

                        if (!isNewStepDone)
                        {
                            isNewStepDone = true;
                        }
                    }
                }
            }
        }


        if (isNewStepDone)
        {
            isNewStepDone = false;

            stepsCounter++;

            if (backStepsCounter < backStepsMaximum)
            {
                backStepsCounter++;
            }

            SortedDictionary<int, Vector2> allBlocksPositions = new SortedDictionary<int, Vector2>();

            foreach (ABlock block in allMovableBlocks)
            {
                block.FinalTransform();

                allBlocksPositions.Add(block.Id, block.CurrentElement.Position);
            }

            GameplayStep nextStep = new GameplayStep(allMoves.Count, EDirection.Right, allBlocksPositions);

            allMoves.Push(nextStep);

            SoundManager.Instance.PlayStoneMove();
            ThrowFinalTransformEvent();
        }
    }

    protected override void MoveBACK()
    {
        if (backStepsCounter == 0)
        {
            return;
        }

        backStepsCounter--;

        if (allMoves.Count > 1)
        {
            allMoves.Pop();

            GameplayStep prevStep = allMoves.Peek();

            stepsCounter--;

            List<ABlock> allMovableBlocks = new List<ABlock>();

            allMovableBlocks.Add(playerBlock);
            //allMovableBlocks.Add(inscriptionBlockBlue);
            //allMovableBlocks.Add(inscriptionBlockYellow);

            if (mobileBlocks != null && mobileBlocks.Count > 0)
            {
                foreach (MobileBlock block in mobileBlocks)
                {
                    allMovableBlocks.Add(block);
                }
            }

            foreach (ABlock block in allMovableBlocks)
            {
                block.CurrentElement.SetEmpty();

                Vector2 blockPosition = prevStep.GetPositionById(block.Id);

                block.ChangePoint(gameBoardGrid[(int)blockPosition.x, (int)blockPosition.y]);
                block.CurrentElement.SetFull();
            }
        }

        SoundManager.Instance.PlayStoneMove();
        ThrowFinalTransformEvent();
    }

    protected override void StartStoneMatchEffects()
    {
        playerBlock.StartStoneMatchEffects();
        //inscriptionBlockBlue.StartStoneMatchEffects();
        //inscriptionBlockYellow.StartStoneMatchEffects();
    }

    public override void PutBlockObjects()
    {
        List<ABlock> allBlocks = new List<ABlock>();

        allBlocks.Add(playerBlock);
        //allBlocks.Add(inscriptionBlockBlue);
        //allBlocks.Add(inscriptionBlockYellow);

        //allBlocks.Add(targetBlockRed);
        //allBlocks.Add(targetBlockBlue);
        //allBlocks.Add(targetBlockYellow);

        if (mobileBlocks != null && mobileBlocks.Count > 0)
        {
            foreach (MobileBlock block in mobileBlocks)
            {
                allBlocks.Add(block);
            }
        }

        if (staticBlocks != null && staticBlocks.Count > 0)
        {
            foreach (StaticBlock block in staticBlocks)
            {
                allBlocks.Add(block);
            }
        }

        foreach (ABlock block in allBlocks)
        {
            block.BlockPosition = new Vector3(block.CurrentElement.X, block.CurrentElement.Y, 0.0f);
        }
    }

    public override void RemoveBlockObjects()
    {
        List<ABlock> allBlocks = new List<ABlock>();

        allBlocks.Add(playerBlock);
        //allBlocks.Add(inscriptionBlockBlue);
        //allBlocks.Add(inscriptionBlockYellow);

        //allBlocks.Add(targetBlockRed);
        //allBlocks.Add(targetBlockBlue);
        //allBlocks.Add(targetBlockYellow);

        if (mobileBlocks != null && mobileBlocks.Count > 0)
        {
            foreach (MobileBlock block in mobileBlocks)
            {
                allBlocks.Add(block);
            }
        }

        if (staticBlocks != null && staticBlocks.Count > 0)
        {
            foreach (StaticBlock block in staticBlocks)
            {
                allBlocks.Add(block);
            }
        }

        foreach (ABlock block in allBlocks)
        {
            block.BlockPosition = new Vector3(200, 200, 200);
        }
    }

    public override void MoveBlockObjects(float lerpAlpha, float minDistance)
    {
        List<ABlock> allBlocks = new List<ABlock>();

        allBlocks.Add(playerBlock);
        //allBlocks.Add(inscriptionBlockBlue);
        //allBlocks.Add(inscriptionBlockYellow);

        if (mobileBlocks != null && mobileBlocks.Count > 0)
        {
            foreach (MobileBlock block in mobileBlocks)
            {
                allBlocks.Add(block);
            }
        }

        foreach (ABlock block in allBlocks)
        {
            if (Vector3.Distance(block.BlockPosition, new Vector3(block.CurrentElement.X, block.CurrentElement.Y, 0.0f)) >= minDistance)
            {
                block.BlockPosition = Vector3.Lerp(block.BlockPosition, new Vector3(block.CurrentElement.X, block.CurrentElement.Y, 0.0f), lerpAlpha);
            }
            else
            {
                block.BlockPosition = new Vector3(block.CurrentElement.X, block.CurrentElement.Y, 0.0f);
            }
        }


        foreach (ABlock block in allBlocks)
        {
            if (block.BlockPosition != new Vector3(block.CurrentElement.X, block.CurrentElement.Y, 0.0f))
            {
                return;
            }
        }

        ThrowTransitOverEvent();

        //if (inscriptionBlockRed.CurrentElement == targetBlockRed.CurrentElement && inscriptionBlockBlue.CurrentElement == targetBlockBlue.CurrentElement && inscriptionBlockYellow.CurrentElement == targetBlockYellow.CurrentElement)
        //{
        //    SoundManager.Instance.PlayStoneStop();
        //    StartStoneMatchEffects();
        //    ThrowStonesMatchEvent();
        //    return;
        //}

        if (stepsCounter > GameStartData.MaximumStepsCount)
        {
            ThrowErrorEvent(EErrorType.StepsCount);
        }
    }
}

