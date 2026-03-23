public class CellData
{
    private TileDefinition structure;
    private TileDefinition floor;

    public CellData()
    {
        this.structure = null;
        this.floor = null;
    }

    public CellData(TileDefinition floor)
    {
        this.structure = null;
        this.floor = floor;
    }

    public CellData(TileDefinition structure, TileDefinition floor)
    {
        this.structure = structure;
        this.floor = floor;
    }
}