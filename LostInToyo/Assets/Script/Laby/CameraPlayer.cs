using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    public Vector3 offset;
    
    private void Start()
    {
        offset = transform.position - player.position;
    }
    void Update()
    {
        Vector3 cameraposition = player.position + offset;
        transform.position = cameraposition;
    }
}
