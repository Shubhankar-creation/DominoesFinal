using UnityEngine;

public class spawnDominoes: MonoBehaviour
{
    [SerializeField] private GameObject dominosPrefab;

    public int maxDominoes = 10;

    private Touch touch;
    private Vector3 instancePos;
    private Vector3[] instaceRot = new Vector3[30];
    private int k = 0, j = 0;
    private GameObject newDominos;
    private GameObject[] dominosGO = new GameObject[3];
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && k <= maxDominoes)
        {
            touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (touch.phase == TouchPhase.Began)
            {

                if (Physics.Raycast(ray, out hit))
                {

                    if (hit.collider.tag == "GROUND")
                    {


                        newDominos = Instantiate(dominosPrefab, new Vector3(hit.point.x, 0.25f, hit.point.z), Quaternion.Euler(0f, 90f, 0f));
                        newDominos.transform.parent = this.transform;
                        dominosGO[j] = newDominos; j = j + 1;

                        setRot();

                        instaceRot[k] = hit.point;
                        k = k + 1;
                    }
                }
            }

            if (touch.phase == TouchPhase.Moved)
            {
                if (Physics.Raycast(ray, out hit))
                {

                    if (hit.collider.tag == "GROUND")
                    {
                        instancePos = hit.point;
                        float dist = Vector3.Distance(instancePos, instaceRot[k - 1]);

                        if (dist >= 0.2f)
                        {
                            newDominos = Instantiate(dominosPrefab, new Vector3(hit.point.x, 0.25f, hit.point.z), Quaternion.Euler(0f, 90f, 0f));
                            newDominos.transform.parent = this.transform;
                            instaceRot[k] = instancePos;

                            dominosGO[j] = newDominos; j = j + 1;

                            setRot();
                            k = k + 1;
                        }

                    }
                }
            }

        }
    }

    void setRot()
    {
        if (j >= 3)
        {
            Vector3[] dirToFace = new Vector3[2];

            dirToFace[0] = dominosGO[0].transform.position - dominosGO[1].transform.position;
            dominosGO[0].transform.rotation = Quaternion.LookRotation(dirToFace[0]);

            dirToFace[1] = dominosGO[1].transform.position - dominosGO[2].transform.position;
            dominosGO[1].transform.rotation = Quaternion.LookRotation(dirToFace[1]);

            dominosGO[0] = dominosGO[1];
            dominosGO[1] = dominosGO[2];

            j = 2;
        }

    }
}
