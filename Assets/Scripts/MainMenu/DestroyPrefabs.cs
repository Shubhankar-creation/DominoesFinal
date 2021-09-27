using UnityEngine;

public class DestroyPrefabs : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DominoesMenu"))        // Destroys any unused Dominoes
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("GroundMenu"))         // Destroys any unused Platfrom
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }

    }
}
