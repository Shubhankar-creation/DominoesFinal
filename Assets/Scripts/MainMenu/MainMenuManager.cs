using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Function Envokes");
        SceneManager.LoadScene(1);  
    }
}
