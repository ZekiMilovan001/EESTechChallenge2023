using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantController : MonoBehaviour
{
    //[SerializeField]
    public Vector3 rotationCenter;

    public GameObject monyEmoji;
    [SerializeField]
    float rotationRadius = 2f, angularSpeed = 2f,offsetY = 1;

    float posX, posY, angle = 0f;

    private float rnd;


    private void Awake()
    {
        monyEmoji.SetActive(false);
        rotationCenter = transform.position;
        Vector3 tmp = rotationCenter;
        monyEmoji.transform.position = new Vector3(tmp.x, tmp.y + offsetY,0);
    }


    void Update()
    {


        posX = rotationCenter.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.y + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);

        Vector3 tmp = transform.position;
        monyEmoji.transform.position = new Vector3(tmp.x, tmp.y + offsetY, 0);

        rnd = Random.Range(0, 300);
        if (rnd < 0.0005) {
            monyEmoji.SetActive(true);
            StartCoroutine(Wait(monyEmoji, 0.9f));
        }

        angle = angle + Time.deltaTime * angularSpeed;

        if (angle > 360f)
            angle = 0f;
    }

    private Vector3 initialPos;




 
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
