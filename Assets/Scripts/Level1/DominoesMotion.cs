using System.Collections;
using UnityEngine;

public class DominoesMotion : MonoBehaviour
{
    public bool inMotion = true;
    public int flag = 1;
    public inGameUi dFire;
    GameObject[] allDominoes;
    private void Update()
    {
        if (dFire.canFire)
        {
            allDominoes = GameObject.FindGameObjectsWithTag("Dominoes");

            StartCoroutine("checkMotion");
        }
    }

    private void dominoesVelocity()
    {

        foreach (GameObject go in allDominoes)
        {
            if (go.GetComponent<Rigidbody>().velocity.magnitude > 0)
            {
                Debug.Log(go.GetComponent<Rigidbody>().velocity.magnitude);
                inMotion = true;
                flag = 1;
                break;
            }
            else
            {
                flag = 0;
            }
        }
        StartCoroutine("checkMotion");

    }

    public IEnumerator checkMotion()
    {
        yield return new WaitForSeconds(1f);
        runafter3sec();
    }

    private void runafter3sec()
    {
        if (flag == 0)
        {
            dFire.gameEndUI();
        }
        else
        {
            dominoesVelocity();
        }
    }
}
