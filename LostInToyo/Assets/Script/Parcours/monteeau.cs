using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monteeau : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector3(0, -19, -94);
    }
    void Update()
    {
        //  Vector3 blocposition = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y) - offset;
        //transform.position = blocposition;
        if (transform.position.y < 25)
        {
            Vector3 movement = new Vector3(
              0,
              Camera.main.transform.position.y - 3,
              -94);
            transform.position = movement;
        }
        

    }
}


