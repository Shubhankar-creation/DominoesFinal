using UnityEngine;

public class CameraMovemnet : MonoBehaviour
{
    void Update()       // moves the Camera in Forward Direction with constant speed
    {
        transform.transform.position += Vector3.forward * 0.8f * Time.deltaTime;
    }
}
