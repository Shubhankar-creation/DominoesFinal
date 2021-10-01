using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getAllDominoesFall : MonoBehaviour
{

    public inGameUi getDominoes;
    GameObject[] allFallDominoes;
    private int totalDominoesFall = 0;

    void Update()
    {
        if (getDominoes.dominoesFall)
        {
            allFallDominoes = GameObject.FindGameObjectsWithTag("Dominoes");
            foreach (GameObject dominoes in allFallDominoes)
            {
                if (dominoes.transform.position.y <= 0f)
                {
                    totalDominoesFall++;
                }
            }
            getDominoes.dominoesFall = false;
        }
    }
}
