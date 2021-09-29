using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBall : MonoBehaviour
{

    public InGameUi getFire;        // to be impilment via UI

    void Update()
    {
        if (getfire.canfire)
        {
            debug.log("sphere should move");

            transform.rotate(vector3.up, -1 * getfire.firerot.z);

            startcoroutine("fire");

            getfire.canfire = false;
        }

    }

    IEnumerator Fire()
    {
        yield return new WaitForSeconds(1);
    }
}
