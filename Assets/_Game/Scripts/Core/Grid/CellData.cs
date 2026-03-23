using UnityEngine;

public class CellData : MonoBehaviour
{
    private TileDefinition structure;
    private TileDefinition floor;

    public CellData(TileDefinition structure, TileDefinition floor)
    {
        this.structure = structure;
        this.floor = floor;
    }

    public TileDefinition getCellType()
    {
        return;
    }

    // TODO: add a refenence to objects on the floor

    // TODO: add a reference to the items place on the floor
}