using UnityEngine;

public class DestroyPrefabs : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("D_Destroy_Col"))        // Destroys any unused Dominoes
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("G_Destroy_Col"))         // Destroys any unused Platfrom
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }

    }
}
