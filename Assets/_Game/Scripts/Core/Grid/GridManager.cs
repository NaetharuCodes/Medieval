using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int gridSize = 1024;

    private CellData[,] cells;

    void Start()
    {
        Debug.Log("Hello World");

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
}