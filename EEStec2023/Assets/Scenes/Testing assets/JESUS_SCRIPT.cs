using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JESUS_SCRIPT : MonoBehaviour
{
    public bool jesusWasThere = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {

            FIRSTLevel.Instance.interactedWithJesus = true;
        }
    }

}
