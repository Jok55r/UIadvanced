using UnityEngine;

public class AimMechanic : MonoBehaviour
{
    public Texture2D mouseCursor;

    Vector2 hotSpot = new Vector2(0, 0);
    CursorMode cursorMode = CursorMode.Auto;

    private void Start()
    {
        Cursor.SetCursor(mouseCursor, hotSpot, cursorMode);
    }
}