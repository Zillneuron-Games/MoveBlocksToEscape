using System;
using System.Collections.Generic;

public abstract class AGame
{
    #region Events

    public event EventHandler<EventArgs> eventBlocksMatch;
    public event EventHandler<EventArgs> eventFinalTransform;
    public event EventHandler<EventArgs> eventTransitOver;
    public event EventHandler<GameErrorEventArgs> eventError;

    #endregion Events

    #region Variables

    protected int id;
    protected int stepsCounter;
    protected int coinsCounter;

    protected int playedNumber;

    protected int backStepsCounter;
    protected int backStepsMaximum;

    protected PlayerBlock playerBlock;
    protected List<MobileBlock> mobileBlocks;
    protected List<StaticBlock> staticBlocks;
    protected List<PawnBlock> pawnBlocks;
    protected List<PawnTargetBlock> pawnTargetBlocks;
    protected List<TumblerBlock> tumblerBlocks;
    protected List<TumblerTargetBlock> tumblerTargetBlocks;

    protected Stack<GameplayStep> allMoves;

    protected GameBoardGrid gameBoardGrid;
    protected GameDataDynamic gameDataDynamic;

    #endregion Variables

    #region Properties

    public int Id
    {
        get { return id; }
    }

    public int PlayedCount
    {
        get { return playedNumber; }
    }

    public int StepsCount
    {
        get { return stepsCounter; }
    }

    public int CoinsCount
    {
        get { return coinsCounter; }
    }

    public int BestStepsCount
    {
        get { return gameDataDynamic.BestSteps; }
    }

    public int BestCoinsCount
    {
        get { return gameDataDynamic.BestCoins; }
    }

    public int BackStepsCount
    {
        get { return backStepsCounter; }
    }

    public GameDataDynamic DynamicData
    {
        get
        {
            return gameDataDynamic;
        }
    }

    #endregion Properties

    #region Constructors

    public AGame(GameBoardGrid gameBoardGrid, int id, int stepsBest, int coinsBest, int playedNumber, PlayerBlock playerBlock, List<MobileBlock> mobileBlocks, List<StaticBlock> staticBlocks, List<PawnBlock> pawnBlocks, List<PawnTargetBlock> pawnTargetBlocks, List<TumblerBlock> tumblerBlocks, List<TumblerTargetBlock> tumblerTargetBlocks, Stack<GameplayStep> allMoves)
    {
        this.gameBoardGrid = gameBoardGrid;
        this.id = id;
        this.stepsCounter = 0;
        this.coinsCounter = 0;

        this.playedNumber = playedNumber;

        this.backStepsCounter = 0;
        this.backStepsMaximum = GameStartData.MaximumStepsCount;

        this.playerBlock = playerBlock;
        this.mobileBlocks = mobileBlocks;
        this.staticBlocks = staticBlocks;
        this.pawnBlocks = pawnBlocks;
        this.pawnTargetBlocks = pawnTargetBlocks;
        this.tumblerBlocks = tumblerBlocks;
        this.tumblerTargetBlocks = tumblerTargetBlocks;

        this.gameDataDynamic = new GameDataDynamic(id, stepsBest, coinsBest, playedNumber + 1);

        this.allMoves = allMoves;
    }

    #endregion Constructors

    #region Methods

    public void MoveBlocks(EDirection direction)
    {
        switch (direction)
        {
            case EDirection.Up: MoveUP(); break;
            case EDirection.Down: MoveDOWN(); break;
            case EDirection.Left: MoveLEFT(); break;
            case EDirection.Right: MoveRIGHT(); break;
            case EDirection.None: MoveBACK(); break;
        }
    }

    protected void ThrowFinalTransformEvent()
    {
        EventHandler<EventArgs> tempFinalTransformEvent = eventFinalTransform;

        if (tempFinalTransformEvent != null)
        {
            tempFinalTransformEvent(this, new EventArgs());
        }
    }

    protected void ThrowStonesMatchEvent()
    {
        gameDataDynamic.UpdateBestStep(stepsCounter);
        CalculateCoins();
        gameDataDynamic.UpdateBestCoins(coinsCounter);

        EventHandler<EventArgs> tempBlockMatchEvent = eventBlocksMatch;

        if (tempBlockMatchEvent != null)
        {
            tempBlockMatchEvent(this, new EventArgs());
        }

    }

    protected void ThrowTransitOverEvent()
    {
        EventHandler<EventArgs> tempTransformOverEvent = eventTransitOver;

        if (tempTransformOverEvent != null)
        {
            tempTransformOverEvent(this, new EventArgs());
        }

    }

    protected void ThrowErrorEvent(EErrorType errorKey)
    {
        EventHandler<GameErrorEventArgs> tempErrorEvent = eventError;

        if (tempErrorEvent != null)
        {
            tempErrorEvent(this, new GameErrorEventArgs(errorKey));
        }

    }

    protected void CalculateCoins()
    {
        float levelNumber = id;
        float gameMinimalSteps = 10;

        UnityEngine.Debug.LogError("Change Calculation.");

        float playerSteps = StepsCount;

        //if (stepsMinimum > StepsCount)
        //{
        //    //BugReport.Instance.MinimumSteps(id, stepsMinimum, StepsCount);

        //    gameMinimalSteps = StepsCount;
        //    playerSteps = stepsMinimum;
        //}

        float mainFactorFloat = levelNumber + 3 * gameMinimalSteps - playerSteps;

        coinsCounter = mainFactorFloat > (levelNumber / 2.0f) ? (int)mainFactorFloat : (int)(levelNumber / 2.0f);
    }

    protected abstract void MoveUP();

    protected abstract void MoveDOWN();

    protected abstract void MoveLEFT();

    protected abstract void MoveRIGHT();

    protected abstract void MoveBACK();

    public abstract void PutBlockObjects();

    public abstract void RemoveBlockObjects();

    public abstract void MoveBlockObjects(float lerpAlpha, float minDistance);

    protected abstract void StartStoneMatchEffects();

    #endregion Methods

}