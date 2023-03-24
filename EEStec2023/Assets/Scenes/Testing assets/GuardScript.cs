using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardScript : MonoBehaviour
{

    public static int[] positions = { -5, -10, -15, -10, -5, 0, 5, 10, 15, 10, 5, 0 };
    public int N = positions.Length;

    public int health = 10;
    bool touching = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health<=0)
            SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));

        if (touching && Input.GetMouseButtonDown(0))
        {
            health--;
            StartCoroutine(Wiggle());
            Debug.Log(health);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        /*if (collision.gameObject.tag == "MOUSE")
        {
            health--;
            Debug.Log(health);
        }*/


        if (collision.gameObject.tag == "MOUSE")
        {
            
            touching = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MOUSE")
        {
            touching = false;
        }
    }
    IEnumerator Wiggle()
    {
        Debug.Log("Start Coroutine");
        for (int x = 1; x < N; x++)
        {

            transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,positions[x]);
            
            //Increase or decrease the parameter of WaitForSeconds
            //to test different speeds.
            yield return new WaitForSeconds(0.02f);
        }
        Debug.Log("End Coroutine");
    }

}
