using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public int Tab = 0;
    public bool Escape = false;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Escape = !Escape;
        }
        if (Escape)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("game-1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Cancel()
    {
        SceneManager.LoadScene("spring");
    }


}
