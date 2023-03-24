using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningFish : MonoBehaviour
{
    private bool spawned = false;
    public JESUS_SCRIPT Jesus;
    public GameObject Fish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FIRSTLevel.Instance.interactedWithJesus && !spawned) {
            Instantiate(Fish);
            spawned = true;

            // IMPLEMENT ANIMATION


            }
    }
}
