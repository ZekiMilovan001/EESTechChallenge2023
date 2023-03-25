using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorScript : MonoBehaviour
{
    public GameObject parrent;
    // Start is called before the first frame update

    public Vector3 offset;

    private void Awake()
    {
        //transform.position = parrent.transform.position;
    }
    void Start()
    {
        transform.position = parrent.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
