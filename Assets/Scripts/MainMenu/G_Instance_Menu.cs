using System.Collections;
using UnityEngine;

public class G_Instance_Menu : MonoBehaviour
{

    public GameObject menuGround;
    private float k = 0f;
    void Start()
    {
        instanceG();
        StartCoroutine("spawnGround");
    }

    IEnumerator spawnGround()
    {
        yield return new WaitForSeconds(10f);
        instanceG();
    }

    private void instanceG()
    {
        k += 15f;
        GameObject newGround = Instantiate(menuGround, new Vector3(0f, 0f, k), Quaternion.Euler(new Vector3(90f, 0f, 0f))) as GameObject;
        newGround.transform.parent = transform;
        StartCoroutine("spawnGround");
    }
}
