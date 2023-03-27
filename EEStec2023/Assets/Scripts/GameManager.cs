using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Transform panel;
    public GameObject canvas;
    public FIRSTLevel fstLevel;
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void showCanvas()
    {

        canvas.SetActive(false);
        fstLevel.STOP = false;
        Debug.Log("Loading level 2");
        SceneManager.LoadScene("LEVEL2");
    }

    IEnumerator Wait(float t)
    {
        Debug.Log("Start Coroutine");

        yield return new WaitForSeconds(t);
        
        Debug.Log("End Coroutine");
    }


}
