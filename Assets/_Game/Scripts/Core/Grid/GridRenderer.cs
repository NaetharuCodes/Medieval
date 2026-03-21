using UnityEngine;
using UnityEngine.Tilemaps;

public class GridRenderer : MonoBehaviour
{
    public GridManager grid;

    public Tilemap tilemap;

    public TileBase grassTile;
    void Start()
    {
        for (int i = 0; i < grid.gridSize; i++)
        {
            for (int j = 0; j < grid.gridSize; j++)
            {
                tilemap.SetTile(new Vector3Int(i, j, 0), grassTile);
            }
        }
    }
}