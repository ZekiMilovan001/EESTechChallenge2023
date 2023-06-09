﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Animator animator;
    //public SavePlayerPos setPlayerPos;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //transform.position = setPlayerPos.playerPos;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

       /* if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        } */
    }

    public float speed = 2.7f;

    public void Move()
    {

        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);

        //transform.position += Movement * speed * Time.deltaTime;
        transform.position += Movement * speed * Time.deltaTime;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Guard" )
        {
            Debug.Log("Press E");
            PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
            //DontDestroyOnLoad(setPlayerPos);
            //setPlayerPos.playerPos = transform.position;
            SceneManager.LoadScene("FightingGuardScene");
        }

        //collision.gameObject.GetComponent<TalkableNPC>().doSmthng();
    }

}
