using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBall : MonoBehaviour
{

    public Rigidbody rb;
    public inGameUi getFire;
    public float ballSpeed = 30f;

    void Update()
    {
        if (getFire.canFire)
        {
            Debug.Log("sphere should move");

            transform.Rotate(Vector3.up, -1 * getFire.fireRot.z);

            StartCoroutine("Fire");

            getFire.canFire = false;
        }
    }

    IEnumerator Fire()
    {
        yield return new WaitForSeconds(1);
        rb.AddRelativeForce(Vector3.forward * ballSpeed);
    }
}
