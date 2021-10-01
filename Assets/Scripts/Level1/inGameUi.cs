using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inGameUi : MonoBehaviour
{
    GameObject goFire;

    public GameObject fireUI;
    public GameObject fireBtn;
    public GameObject setDom;
    public GameObject setDomBg;
    public GameObject nextLvl;

    public bool canFire, dominoesFall;

    public Vector3 fireRot;

    spawnDominoes canSpawn;
    private void Start()
    {
        canSpawn = GameObject.FindGameObjectWithTag("D-Spawn").GetComponent<spawnDominoes>();
    }

    public void loadLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void gameEndUI()
    {
        setDomBg.active = false;
        dominoesFall = true;
        fireBtn.active = false;
        nextLvl.active = true;
        Debug.Log(dominoesFall);
    }
    public void retryLvl()
    {
        SceneManager.LoadScene(1);
    }

    public void fireBallUI()
    {
        setDom.SetActive(false);
        fireBtn.SetActive(true);
        goFire = Instantiate(fireUI);
        goFire.transform.SetParent(transform);
        goFire.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
        goFire.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, -890f, 0f);
        canSpawn.enabled = false;
    }

    public void onfireClick()
    {
        fireRot = goFire.GetComponent<fireUIRot>().rotaVal;
        canFire = true;
        goFire.active = false;
    }

}
