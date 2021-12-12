using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcam : MonoBehaviour
{
    // Start is called before the first frame update
    

    

    // Update is called once per frame
    private void Start()
    {
        transform.position = new Vector3(0, -19,1);
    }
    void Update()
    {
        //  Vector3 blocposition = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y) - offset;
        //transform.position = blocposition;
        if (transform.position.y < 27)
        {
            Vector3 movement = new Vector3(
          0,
          Camera.main.transform.position.y - 3,
          1);
            transform.position = movement;
        }

    }
}
