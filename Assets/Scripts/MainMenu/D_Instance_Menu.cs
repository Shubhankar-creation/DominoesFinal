using System.Collections;
using UnityEngine;

public class D_Instance_Menu : MonoBehaviour
{

    public GameObject menuDominoes;
    private float k = 2;
    void Start()
    {
        StartCoroutine("spawnDom");
    }

    IEnumerator spawnDom()
    {
        yield return new WaitForSeconds(5f);
        instanceDom();
    }

    private void instanceDom()
    {
        k += 9.6f;
        GameObject newDom = Instantiate(menuDominoes, new Vector3(transform.position.x, 0.265f, k), Quaternion.identity) as GameObject;
        newDom.transform.parent = transform;
        StartCoroutine("spawnDom");
    }
}
