using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToOldScene : MonoBehaviour
{

    public int health = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "MOUSE" && Input.GetMouseButtonDown(0))
        {
            health--;
            Debug.Log(health);
        }
    }
}
