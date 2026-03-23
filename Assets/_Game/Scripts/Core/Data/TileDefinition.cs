using UnityEngine;
using UnityEngine.Tilemaps;

public enum TileMaterialType
{
    cloth,
    wood,
    straw,
    thatch,
    wottleNdaub,
    clayBricks,
    stoneBricks,
    heavyStoneBricks,
    bronze,
    iron,
}

public enum TileFunctionType
{
    floor,
    wall,
    stairs,
}

[CreateAssetMenu(fileName = "New Buildable", menuName = "Buildables/Buildable")]
public class TileDefinition : ScriptableObject
{
    public string displayName;

    public TileBase spriteTile;

    // Units of labor needed to construct the tile
    public int workforceCost;

    // Units of resource needed to construct the tile
    public int buildUnitCost;

    public TileMaterialType unitType;

    public bool combustable;

    public bool attackable;

    // number of heath points a tile has before being destroyed
    public int durability;

    public TileFunctionType tileFunction;
}