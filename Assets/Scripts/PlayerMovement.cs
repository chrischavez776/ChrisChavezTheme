using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public AudioClip sugarClip;
    public AudioClip boboClip;
    public GameManager gm;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(transform.localPosition.x);
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");

        //Debug.Log(xMove);
        transform.Translate(xMove * speed * Time.deltaTime, 0, 0);
        //transform.Translate(0,0,0); this moves an object the given amount of units
        //transform.position = new Vector3(0,0,0); this moves an object to the position on the grid
    }


    /* 
    private void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("Collided");
    } 
    */

    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject.tag == "Coin"){
            gm.PlaySound(sugarClip);
            gm.IncrementScore(1);
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Hazard"){
            gm.PlaySound(boboClip);
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Theme"){
            Debug.Log("Theme Changed");
        }

    }
}

