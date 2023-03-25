using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FISHLevelMovement : MonoBehaviour
{

    public float speed = 0.001f;
    

    private float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x + Time.deltaTime * 0.1f* speed;
        //y = Mathf.Sin(x) * 20;


        Vector3 newPos = new Vector3(x,-3.8f,0);
        transform.position = newPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water") {
            collision.GetComponent<SpriteRenderer>().color = new Color(0.9f, 0.1f, 0.1f, 1.0f);
        }
    }


}
