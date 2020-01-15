using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerDrag : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 lastMousePosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }
    private void OnMouseDrag()
    {
        Vector3 fingerMoveVector = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastMousePosition);
        Vector3 newPosition = transform.position + Vector3.Project(fingerMoveVector, transform.up);
        transform.position = newPosition;
        lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDown()
    {
        lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }
}
