using UnityEngine;

public enum FloorType
{
    Mud,
    Sand,
    Grass,
    Rock,
    Water,
    WoodenPlanks,
    Straw,
    StoneBricks,
    CarvedStone,
    Carpet,
}

public enum WallType
{
    None,
    WoodenFence,
    WoodenWall,
    WattleAndDaub,
    MudBricks,
    StoneBricks,
}

public enum TerrainDifficulty
{
    Normal,
    Difficul,
    Impassable,
}

public class CellData
{
    // Fields - the things I know
    public FloorType floorType;
    public WallType wallType;

    // TODO: add a refenence to objects on the floor

    // TODO: add a reference to the items place on the floor
}