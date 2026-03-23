using UnityEngine;
using System.Collections.Generic;

public class BuildQueueItem
{
    private TileDefinition tile;

    private HashSet<Vector2Int> blueprint = new HashSet<Vector2Int>();

    public BuildQueueItem(TileDefinition tile, HashSet<Vector2Int> blueprint)
    {
        this.tile = tile;
        this.blueprint = blueprint;
    }

    public TileDefinition GetTileDefinition()
    {
        return tile;
    }

    public HashSet<Vector2Int> GetBlueprint()
    {
        return blueprint;
    }
}