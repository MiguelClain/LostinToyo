using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuLaby : MonoBehaviour
{
    public AudioSource audioSource;

    float timeLeft = 60.0f;
    public GameObject GameOver;

    public GameObject Splashy;
    public Text time;
    public Text mort;

    private bool isplaying;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        moveplayer.isDead = false;
        Splashy.SetActive(false);
    }

    void Update()
    {
        if (TutoScript.isplaying)
        {
            Splashy.SetActive(false);
            timeLeft -= Time.deltaTime;
            int timeint = (int)timeLeft;
            time.text = "Temps restant : " + timeint.ToString();
            mort.text = "Mort : " + MainMenu.mort.ToString();
            if (timeLeft < 0)
            {
                GameOver.SetActive(true);
                moveplayer.isDead = true;
                audioSource.Stop();
            }
        }
    }
}
