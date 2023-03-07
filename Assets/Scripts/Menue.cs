using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menue : MonoBehaviour
{
    public GameObject MainMenue;
    public GameObject Options;

    public void Awake()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenue.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void LoadGame()
    {

    }

    public void OptionClick()
    {
        MainMenue.SetActive(false);
        Options.SetActive(true);
    }

    public void Back()
    {
        MainMenue.SetActive(true);
        Options.SetActive(false);
    }

    public void Resume()
    {
        MainMenue.SetActive(false);
    }
    
    public void Leave()
    {
        SceneManager.LoadScene("StartScreen");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
