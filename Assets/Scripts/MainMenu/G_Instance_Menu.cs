using System.Collections;
using UnityEngine;

public class G_Instance_Menu : MonoBehaviour
{

    public GameObject menuGround;
    private float k = 7.5f;
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
        k += 15;
        GameObject newGround = Instantiate(menuGround, new Vector3(0f, 0f, k), Quaternion.Euler(new Vector3(90f, 0f, 90f))) as GameObject;
        newGround.transform.parent = transform;
        StartCoroutine("spawnGround");
    }
}
