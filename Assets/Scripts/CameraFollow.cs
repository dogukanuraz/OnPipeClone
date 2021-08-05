using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;

    private void LateUpdate()
    {
        //Kamera takipi.
        transform.position = target.position + offset;
    }
}
