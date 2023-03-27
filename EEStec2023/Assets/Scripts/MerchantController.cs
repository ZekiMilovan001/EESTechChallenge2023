using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantController : MonoBehaviour
{
    //[SerializeField]
    public Vector3 rotationCenter;

    public SecondLvl sndLvl;

    public GameObject monyEmoji;
    public GameObject TEST;
    //public GameObject toSwap;
    public float MU = 0.0005f;
    [SerializeField]
    float rotationRadius = 2f, angularSpeed = 2f,offsetY = 1;

    float posX, posY, angle = 0f;

    private float rnd;


    private void Awake()
    {
        TEST.SetActive(false);
        monyEmoji.SetActive(false);
        rotationCenter = transform.position;
        Vector3 tmp = rotationCenter;
        monyEmoji.transform.position = new Vector3(tmp.x, tmp.y + offsetY,0);
    }

    bool wasHere = false;
    void Update()
    {
        if (sndLvl.LAZARUS_ALIVE && !wasHere) {
            TEST.SetActive(true);
            monyEmoji.SetActive(false);
            wasHere = true;
        }

        posX = rotationCenter.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.y + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);

        Vector3 tmp = transform.position;
        monyEmoji.transform.position = new Vector3(tmp.x, tmp.y + offsetY, 0);

        rnd = Random.Range(0, 300);
        if (rnd < MU && !sndLvl.LAZARUS_ALIVE) {
            monyEmoji.SetActive(true);
            StartCoroutine(Wait(monyEmoji, 0.9f));
        }

        angle = angle + Time.deltaTime * angularSpeed;

        if (angle > 360f)
            angle = 0f;
    }





 
    // Start is called before the first frame update
    void Start()
    {

        
    }

    IEnumerator Wait(GameObject emoji, float t)
    {
        Debug.Log("Start Coroutine");

        yield return new WaitForSeconds(t);
        emoji.SetActive(false);
        Debug.Log("End Coroutine");
    }

    // Update is called once per frame

}
