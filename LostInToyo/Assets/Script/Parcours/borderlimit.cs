using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderlimit : MonoBehaviour
{
    public Vector3 offset;
   

    // Update is called once per frame
    private void Start()
    {
        transform.position = new Vector3(9, 9, 1);
    }
    void Update()
    {
        //  Vector3 blocposition = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y) - offset;
        //transform.position = blocposition;
        Vector3 movement = new Vector3(
          Camera.main.transform.position.x+9.3f,
          Camera.main.transform.position.y,
          1);
        transform.position = movement;

    }
}
