using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
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
}
