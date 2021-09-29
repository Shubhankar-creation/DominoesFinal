using UnityEngine;

public class fireUIRot : MonoBehaviour
{
    RectTransform fireRot;
    float rotSpeed = 90f;
    public Vector3 rotaVal;
    private void Start()
    {
        fireRot = GetComponent<RectTransform>();
    }
    void Update()
    {
        if (rotaVal.z >= 90f)
        {
            rotSpeed = -90f;
        }
        else if (rotaVal.z <= -90f)
        {
            rotSpeed = 90f;
        }

        rotaVal += Vector3.forward * rotSpeed * Time.deltaTime;
        fireRot.localRotation = Quaternion.Euler(rotaVal);
    }
}
