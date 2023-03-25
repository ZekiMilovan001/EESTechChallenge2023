using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningFish : MonoBehaviour
{
    private bool spawned = false;
    //public JESUS_SCRIPT Jesus;
    public FIRSTLevel fstLevel;
    public GameObject Fish;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (fstLevel.interactedWithJesus && !spawned)
        {
            Instantiate(Fish,transform);
            spawned = true;
            Debug.Log(transform.position);

            // IMPLEMENT ANIMATION


        }
    }
}
