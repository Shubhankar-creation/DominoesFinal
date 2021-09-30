using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inGameUi : MonoBehaviour
{
    GameObject goFire;

    public GameObject fireUI;
    public GameObject fireBtn;
    public GameObject retry, done;

    public bool canFire, dominoesFall;

    public Vector3 fireRot;

    spawnDominoes canSpawn;
    private void Start()
    {
        canSpawn = GameObject.FindGameObjectWithTag("D-Spawn").GetComponent<spawnDominoes>();
    }
    
    public void gameEndUI()
    {
        dominoesFall = true;
        Debug.Log(dominoesFall);
    }
    public void retryLvl()
    {
        SceneManager.LoadScene(1);
    }

    public void fireBallUI()
    {
        retry.SetActive(false);
        done.SetActive(false);
        fireBtn.SetActive(true);
        goFire = Instantiate(fireUI);
        goFire.transform.SetParent(transform);
        goFire.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
        goFire.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, -900f, 0f);
        canSpawn.enabled = false;
    }

    public void onfireClick()
    {
        fireRot = goFire.GetComponent<fireUIRot>().rotaVal;
        Debug.Log("Rotation to shot at is " + fireRot.z);
        canFire = true;
        goFire.active = false;
    }

}
