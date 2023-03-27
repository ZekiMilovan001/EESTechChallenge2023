using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JESUS_SCRIPT : MonoBehaviour
{
    public bool jesusWasThere = false;
    public FIRSTLevel fstLevel;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-5f, -3f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

  
    }

}
