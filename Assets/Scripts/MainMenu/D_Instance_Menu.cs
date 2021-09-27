using System.Collections;
using UnityEngine;

public class D_Instance_Menu : MonoBehaviour
{

    public GameObject menuDominoes;
    private float k;
    void Start()
    {
        k = transform.position.z + 7f;
        instanceDom();
        StartCoroutine("spawnDom");
    }

    IEnumerator spawnDom()
    {
        yield return new WaitForSeconds(10f);
        instanceDom();
    }

    private void instanceDom()
    {
        k += 9;
        GameObject newDom = Instantiate(menuDominoes, new Vector3(transform.position.x, 0f, k), Quaternion.Euler(new Vector3(90f, 0f, 90f))) as GameObject;
        newDom.transform.parent = transform;
        StartCoroutine("spawnDom");
    }
}
