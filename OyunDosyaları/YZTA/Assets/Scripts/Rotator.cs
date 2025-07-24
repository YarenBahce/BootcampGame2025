using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public bool isRotating = true;

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.down * (rotationSpeed * Time.deltaTime));
        }
    }

    public void StopRotation()
    {
        isRotating = false;
    }

    public void StartRotation()
    {
        isRotating = true;
    }
}
