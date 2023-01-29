using UnityEngine;

public class Controls : MonoBehaviour
{
    public Transform Level;
    public float Sensitivity;
    private Vector3 _previousmousePosition;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousmousePosition;
            Level.Rotate(0, -delta.x * Sensitivity, 0);
        }

        _previousmousePosition = Input.mousePosition;

    }
}
