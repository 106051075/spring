using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject illustratedMenu;
    public GameObject plant1;
    public GameObject plant1_r;
    public GameObject plant2;
    public GameObject plant2_r;
    public GameObject plant3;
    public GameObject plant3_r;
    public GameObject plant4;
    public GameObject plant4_r;
    public GameObject plant5;
    public GameObject plant5_r;
    public GameObject plant6;
    public GameObject plant6_r;
    public GameObject page11;
    public GameObject page12;
    public GameObject page13;
    public GameObject page21;
    public GameObject page22;
    public GameObject page31;
    public GameObject page32;
    public GameObject page33;
    public GameObject page41;
    public GameObject page51;
    public GameObject page52;
    public GameObject page61;

    public int Tab = 0;


    void Update()
    {
        print(Tab);
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            Tab += 1;
        }
        if (Tab % 2 == 0)
        {
            illustratedMenu.SetActive(false);
        }
        else
        {
            illustratedMenu.SetActive(true);
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
    public void Restart()
    {
        Application.LoadLevel (Application.loadedLevel);            
    }
    public void Plant1()
    {
        plant1_r.SetActive(true);
        plant2_r.SetActive(false);
        plant3_r.SetActive(false);
        plant4_r.SetActive(false);
        plant5_r.SetActive(false);
        plant6_r.SetActive(false);
    }
    public void Plant2()
    {
        plant1_r.SetActive(false);
        plant2_r.SetActive(true);
        plant3_r.SetActive(false);
        plant4_r.SetActive(false);
        plant5_r.SetActive(false);
        plant6_r.SetActive(false);
    }
    public void Plant3()
    {
        plant1_r.SetActive(false);
        plant2_r.SetActive(false);
        plant3_r.SetActive(true);
        plant4_r.SetActive(false);
        plant5_r.SetActive(false);
        plant6_r.SetActive(false);
    }
    public void Plant4()
    {
        plant1_r.SetActive(false);
        plant2_r.SetActive(false);
        plant3_r.SetActive(false);
        plant4_r.SetActive(true);
        plant5_r.SetActive(false);
        plant6_r.SetActive(false);
    }
    public void Plant5()
    {
        plant1_r.SetActive(false);
        plant2_r.SetActive(false);
        plant3_r.SetActive(false);
        plant4_r.SetActive(false);
        plant5_r.SetActive(true);
        plant6_r.SetActive(false);
    }
    public void Plant6()
    {
        plant1_r.SetActive(false);
        plant2_r.SetActive(false);
        plant3_r.SetActive(false);
        plant4_r.SetActive(false);
        plant5_r.SetActive(false);
        plant6_r.SetActive(true);
    }
    public void Page11()
    {
        page11.SetActive(true);
        page12.SetActive(false);
        page13.SetActive(false);
    }
    public void Page12()
    {
        page12.SetActive(true);
        page11.SetActive(false);
        page13.SetActive(false);
    }
    public void Page13()
    {
        page13.SetActive(true);
        page11.SetActive(false);
        page12.SetActive(false);
    }
    public void Page21()
    {
        page21.SetActive(true);
        page22.SetActive(false);
    }
    public void Page22()
    {
        page22.SetActive(true);
        page21.SetActive(false);
    }
    public void Page31()
    {
        page31.SetActive(true);
        page32.SetActive(false);
        page33.SetActive(false);
    }
    public void Page32()
    {
        page32.SetActive(true);
        page31.SetActive(false);
        page33.SetActive(false);
    }
    public void Page33()
    {
        page33.SetActive(true);
        page31.SetActive(false);
        page32.SetActive(false);
    }
    public void Page41()
    {
        page41.SetActive(true);
    }

    public void Page51()
    {
        page51.SetActive(true);
        page52.SetActive(false);
    }
    public void Page52()
    {
        page52.SetActive(true);
        page51.SetActive(false);
    }
    public void Page61()
    {
        page61.SetActive(true);
    }
}

