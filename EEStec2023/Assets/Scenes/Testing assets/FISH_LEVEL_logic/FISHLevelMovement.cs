using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FISHLevelMovement : MonoBehaviour
{

    public float speed = 0.001f;

    public Sprite handsUP;
    public Sprite handsDOWN;
    public SpriteRenderer JesusIMG;

    public static int[] positions = { -1, -3, -1, 1, 3, 1};
    public int N = positions.Length;

    private bool wigling = false;
    private float x, y, z;
    private int JUGGLE_PARAM = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!wigling) {
            x = transform.position.x + Time.deltaTime * 0.1f * speed;
            Vector3 newPos = new Vector3(x, -3.8f, 0);
            transform.position = newPos;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water") {


            wigling = true;
            SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
            gameObject.GetComponent<SpriteRenderer>().sprite = handsUP;
            sr.sprite = handsUP;
            

            StartCoroutine(Wiggle(collision));
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);

            
            

        }
    }
    IEnumerator Wiggle(Collider2D collision)
    {
        Debug.Log("Start Coroutine");
        for(int i = 1; i < JUGGLE_PARAM;i++)
        for (int x = 1; x < N; x++)
        {

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, positions[x]);
            

                //Increase or decrease the parameter of WaitForSeconds
                //to test different speeds.
                yield return new WaitForSeconds(0.01f);
                collision.GetComponent<SpriteRenderer>().color = new Color(0.0f + 0.003f * (float)(x*i),
                                0.0f + 0.000001f * (float)(x * i), 0.0f + 0.000001f * (float)(x * i), 1.0f);
            }
        wigling = false;
        gameObject.GetComponent<SpriteRenderer>().sprite = handsDOWN;
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = handsDOWN;
        collision.GetComponent<SpriteRenderer>().color = new Color(0.8f, 0.2f, 0.2f, 1.0f);
        Debug.Log("End Coroutine");
    }

}
