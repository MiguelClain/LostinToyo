using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Move : MonoBehaviour {
 
    private Vector2 speed = new Vector2(5, 5);
 
    private Vector2 movement;

    public GameObject pause;
    
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
 
        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);
        
    }
    
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}
