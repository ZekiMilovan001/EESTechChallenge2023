using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecretSupperController : MonoBehaviour
{

    public GameObject canvas;
    // Start is called before the first frame update
    private void Awake()
    {
        //canvas.SetActive(false);
    }
    void Start()
    {
        //canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            canvas.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.L))
            SceneManager.LoadScene("Guard");

        
    }

    
}
