using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public float panSpeed;
    public float zoomSpeed;
    void Update()
    {

        Keyboard kb = Keyboard.current;
        if (kb == null) return;

        Vector2 move = Vector2.zero;
        if (kb.wKey.isPressed) move.y += 1;
        if (kb.sKey.isPressed) move.y -= 1;
        if (kb.aKey.isPressed) move.x -= 1;
        if (kb.dKey.isPressed) move.x += 1;

        Vector3 newPosition = transform.position;
        newPosition.x += move.x * panSpeed * Time.deltaTime;
        newPosition.y += move.y * panSpeed * Time.deltaTime;
        transform.position = newPosition;

        Mouse mouse = Mouse.current;
        if (mouse != null)
        {
            float scroll = mouse.scroll.ReadValue().y;

            float newSize = Camera.main.orthographicSize;
            newSize -= scroll * zoomSpeed;
            newSize = Mathf.Clamp(newSize, 2f, 50f);
            Camera.main.orthographicSize = newSize;
        }
    }
}