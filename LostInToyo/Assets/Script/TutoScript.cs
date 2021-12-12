using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoScript : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject Tuto;

    public static bool isplaying;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        Tuto.SetActive(true);
        audioSource.Stop();
        isplaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.anyKeyDown && !isplaying)
        {
            Time.timeScale = 1f;
            Tuto.SetActive(false);
            audioSource.Play();
            isplaying = true;
        }
    }
}
