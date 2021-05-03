using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{   
    public static bool Gameispaused  = false;
    public GameObject PauseMenuUI;

        
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("pressed escape button");
            if(Gameispaused)
            {
                Resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Gameispaused=false;
    }
        void pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Gameispaused=true;
    }  
     public void gobacktomainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT !");
        Application.Quit();
    }    
   

}
