using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIRSTLevel : MonoBehaviour
{


    //public GameObject canvas;

    public static FIRSTLevel Instance;
    public bool interactedWithJesus = false;
    public bool STOP = false;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
