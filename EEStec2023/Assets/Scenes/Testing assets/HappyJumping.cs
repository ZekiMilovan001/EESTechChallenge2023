using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyJumping : MonoBehaviour
{

    public int JUMP_PARAM = 700;
    public static float[] jumpy = { 0.2f,  0.6f, 0.8f, 1f, 0.8f,0.4f,0.2f };
    public int N = jumpy.Length;


    private Vector3 fixedPos;

    private void Awake()
    {
        fixedPos = transform.position;
        StartCoroutine(Wait(15.2f + Random.Range(-0.5f,1.4f)));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PROP")
        {
            StartCoroutine(Wiggle());
        }
    }

    IEnumerator Wiggle()
    {
        Debug.Log("Start Coroutine");
        for (int i = 1; i < JUMP_PARAM; i++)
            for (int x = 0; x < N; x++)
            {
                Vector3 tmp = new Vector3(0, (float)jumpy[x], 0);
                transform.position = fixedPos + tmp;
                //transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, positions[x]);


                //Increase or decrease the parameter of WaitForSeconds
                //to test different speeds.
                yield return new WaitForSeconds(0.025f);
            }
        transform.position = fixedPos;
        Debug.Log("End Coroutine");
    }
    IEnumerator Wait(float t)
    {
        Debug.Log("Start Coroutine");

        yield return new WaitForSeconds(t);

        Debug.Log("End Coroutine");
        StartCoroutine(Wiggle());

    }
}

