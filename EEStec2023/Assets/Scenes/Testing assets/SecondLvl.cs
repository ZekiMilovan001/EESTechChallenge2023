using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLvl : MonoBehaviour
{


    //public GameObject canvas;

    public Sprite AliveLazarus;
    public GameObject Lazarus;
    public GameObject canvas;

    public static SecondLvl Instance;
    public bool interactedWithJesus = true;
    public bool LAZARUS_ALIVE = false;
    public bool doneUI = false;

    private void Awake()
    {
        if (Instance != null)
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


    public void helpLazarus()
    {
        doneUI = true;
        LAZARUS_ALIVE = true;
        Lazarus.GetComponent<SpriteRenderer>().sprite = AliveLazarus;
        Lazarus.transform.eulerAngles =  new Vector3(0, 0, 0);
        canvas.SetActive(false);
    }

}
