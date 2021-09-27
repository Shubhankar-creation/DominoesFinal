using UnityEngine;

public class CameraMovemnet : MonoBehaviour
{
    public float camSpeed = 1f;
    void Update()       // moves the Camera in Forward Direction with constant speed
    {
        transform.transform.position += Vector3.forward * camSpeed * Time.deltaTime;
    }
}
