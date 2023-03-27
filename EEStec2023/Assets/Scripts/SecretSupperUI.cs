using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretSupperUI : MonoBehaviour
{
    public GameObject canvas;

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
        UnityEngine.Debug.Log("Radi");
        canvas.SetActive(true);
    }
    public void breadAndWine() { }

    public void giveHenny() { }

    public void giveMeat()
    {

    }
}
