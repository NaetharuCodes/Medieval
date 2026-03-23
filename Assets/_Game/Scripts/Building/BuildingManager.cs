using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

public class BuildingManager : MonoBehaviour
{

    public GameObject hoverSprite;

    public GridManager gridManager;

    public HashSet<Vector2Int> blueprint = new HashSet<Vector2Int>();

    public TileBase blueprintTile;

    public Tilemap overlayTilemap;

    public List<BuildQueueItem> buildQueue = new List<BuildQueueItem>();

    // TODO: This is a temp measure for testing. Replace this with a way to have
    // the tile change based on the player pallet choice.
    public TileDefinition selectedTileDefinition;

    public void Update()
    {
        // Get the current grid tile location of the mouse
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Vector3 screenPos = new Vector3(mousePos.x, mousePos.y, 0);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        Vector2Int gridPos = new Vector2Int(Mathf.FloorToInt(worldPos.x), Mathf.FloorToInt(worldPos.y));

        // Set the mouse hover tile indicator sprite
        hoverSprite.transform.position = new Vector3(gridPos.x + 0.5f, gridPos.y + 0.5f, 5);

        Mouse mouse = Mouse.current;

        if (mouse.leftButton.isPressed)
        {
            blueprint.Add(gridPos);
            overlayTilemap.SetTile(new Vector3Int(gridPos.x, gridPos.y, 0), blueprintTile);
        }

        if (mouse.rightButton.isPressed)
        {
            blueprint.Remove(gridPos);
            overlayTilemap.SetTile(new Vector3Int(gridPos.x, gridPos.y, 0), null);
        }

        Keyboard kb = Keyboard.current;
        if (kb.bKey.isPressed) AcceptBuild();
    }

    public void AddTileToBlueprint(Vector2Int location)
    {
        blueprint.Add(location);
    }

    public void AcceptBuild()
    {
        if (blueprint.Count == 0) return;

        BuildQueueItem item = new BuildQueueItem(selectedTileDefinition, blueprint);
        buildQueue.Add(item);

        foreach (Vector2Int vec in blueprint)
        {
            gridManager.UpdateCell(vec, selectedTileDefinition);
            overlayTilemap.SetTile(new Vector3Int(vec.x, vec.y, 0), null);
        }

        blueprint = new HashSet<Vector2Int>();
    }
}