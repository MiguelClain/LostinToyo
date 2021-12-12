using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    //GameOver -> Reload Scene
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        MainMenu.mort += 1;

    }

    //GameOver -> Menu
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
