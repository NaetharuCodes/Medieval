using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    public int gridSize = 1024;

    private CellData[,] cells;

    public TileBase foundationTile;

    public Tilemap terrainTilemap;

    void Start()
    {
        cells = new CellData[gridSize, gridSize];

        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                cells[i, j] = new CellData();
            }
        }
    }

    public CellData GetCellData
    (int x, int y)
    {
        // Check to guard against requests out of bounds
        if (x >= cells.GetLength(0)) return null;
        if (x < 0) return null;

        if (y >= cells.GetLength(1)) return null;
        if (y < 0) return null;

        return cells[x, y];
    }

    public void UpdateCell(Vector2Int location, TileDefintion tileDefinition)
    {
        cells[location.x, location.y] = new CellData(tileDefinition);
        terrainTilemap.SetTile(new Vector3Int(location.x, location.y, 0), foundationTile);
    }
}