using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    [SerializeField] Transform player;
    public Vector3 offset;
    

    public Vector2 speed = new Vector2(2, 2);
    private Vector2 direction = new Vector2(0, 1);


    // Update is called once per frame
    /*private void Start()
    {
        offset = transform.position - player.position;
    }*/
    private void Start()
    {
        Camera.main.transform.position = new Vector3(0, -15, -204);
    }
    void Update()
    {
        //Vector3 cameraposition = player.position + offset;
        //transform.position = cameraposition;

        Vector3 movement = new Vector3(
          speed.x * direction.x,
          speed.y * direction.y,
          0);
        movement *= Time.deltaTime;

        Camera.main.transform.Translate(movement);
        if(Camera.main.transform.position.y > 32)
        {
            direction = new Vector2(1, 0);
            
        }
        if (Camera.main.transform.position.x > 90)
        {
            direction = new Vector2(0, 0);

        }
    }
}
