using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovableJesus : MonoBehaviour
{


    //public int currLVL;

    public float speed = 0.001f;

    public Sprite handsUP;
    public Sprite handsDOWN;
    public SpriteRenderer JesusIMG;
    public GameObject canvas;

    public FIRSTLevel fstLevel;

    //EMOJIS
    public GameObject whaleEmoji;
    public GameObject nailsEmoji;

    public static int[] positions = { -1, -3, -1, 1, 3, 1 };
    public int N = positions.Length;

    //private bool STOP = false;

    private float x, y;
    public int JUGGLE_PARAM = 40;
    // Start is called before the first frame update


    private void Awake()
    {
        nailsEmoji.SetActive(false);

        //transform.position = new Vector3(-10f, -0.64f, 0);
        whaleEmoji.SetActive(false);
    }

    void Start()
    {
        transform.position = new Vector3(-5, -3, 0);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.R))
        {
            whaleEmoji.SetActive(true);
            StartCoroutine(Wait(whaleEmoji, 0.8f));
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            nailsEmoji.SetActive(true);
            StartCoroutine(Wait(nailsEmoji, 0.8f));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {


            //fstLevel.STOP = true;
            SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
            gameObject.GetComponent<SpriteRenderer>().sprite = handsUP;
            sr.sprite = handsUP;


            StartCoroutine(Wiggle(collision));
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        }

        else if (collision.gameObject.tag == "STOP")
        {
            //fstLevel.STOP = true;
            canvas.SetActive(true);
        }
        else if (collision.gameObject.tag == "THEEND")
        {
            SceneManager.LoadScene("THE_END");
        }

    }
    IEnumerator Wiggle(Collider2D collision)
    {
        Debug.Log("Start Coroutine");
        for (int i = 1; i < JUGGLE_PARAM; i++)
            for (int x = 1; x < N; x++)
            {

                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, positions[x]);
                //nailsEmoji.transform.rotation.SetEulerAngles(0, 0, 0);

                //Increase or decrease the parameter of WaitForSeconds
                //to test different speeds.
                yield return new WaitForSeconds(0.01f);
                collision.GetComponent<SpriteRenderer>().color = new Color(0.0f + 0.0037f * (float)(x * i),
                                0.0f + 0.000001f * (float)(x * i), 0 + 0.00004f * (float)(x * i), 1.0f);
            }
        //fstLevel.STOP = false;
        gameObject.GetComponent<SpriteRenderer>().sprite = handsDOWN;
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = handsDOWN;
        collision.GetComponent<SpriteRenderer>().color = new Color(0.8f, 0.2f, 0.2f, 1.0f);
        //nailsEmoji.SetActive(true);
        //StartCoroutine(Wait(nailsEmoji, 3.6f));
        Debug.Log("End Coroutine");
    }
    IEnumerator SummonFish()
    {
        Debug.Log("Start Coroutine");
        for (int i = 1; i < JUGGLE_PARAM; i++)
            for (int x = 1; x < N; x++)
            {

                //transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, positions[x]);

                yield return new WaitForSeconds(0.01f);
            }
        //fstLevel.STOP = false;
        gameObject.GetComponent<SpriteRenderer>().sprite = handsDOWN;
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = handsDOWN;
        //fstLevel.interactedWithJesus = true;
        //fstLevel.STOP = false;
        whaleEmoji.SetActive(true);
        StartCoroutine(Wait(whaleEmoji, 0.9f));
        Debug.Log("End Coroutine");
    }
    IEnumerator Wait(GameObject emoji, float t)
    {
        Debug.Log("Start Coroutine");

        yield return new WaitForSeconds(t);
        emoji.SetActive(false);
        Debug.Log("End Coroutine");
    }

}
