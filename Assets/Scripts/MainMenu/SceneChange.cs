using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);         //creates a ray which which start from the 
            RaycastHit hit;                                                             // touch position

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("MainCamera"))          // if the ray collides with the GameObject with tag then the 
                {                                                   // game starts
                    SceneManager.LoadScene(1);
                }
            }
        }
    }
}
