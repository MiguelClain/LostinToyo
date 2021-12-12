using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoFinal : MonoBehaviour
{
    private VideoPlayer m_VideoPlayer;
    public GameObject AreyouSure;

    private int totalTap = 0;
    public float tapdelay = 0;

    void Awake()
    {
        m_VideoPlayer = GetComponent<VideoPlayer>();
        m_VideoPlayer.loopPointReached += OnMovieFinished; // loopPointReached is the event for the end of the video
    }

    void OnMovieFinished(VideoPlayer player)
    {
        Debug.Log("Event for movie end called");
        player.Stop();
        //ICI CHARGER LA SCÈNE VOULUE
        SceneManager.LoadScene("MainMenu");
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            totalTap += 1;
        }

        if (totalTap == 1 && tapdelay < 5.0)
        {
            AreyouSure.SetActive(true);
            m_VideoPlayer.Pause();
            tapdelay += Time.deltaTime;
        }

        if (totalTap == 2 && tapdelay < 5.0)
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (tapdelay >= 5.0)
        {
            totalTap = 0;
            tapdelay = 0;
            AreyouSure.SetActive(false);
            m_VideoPlayer.Play();
        }
    }
}
