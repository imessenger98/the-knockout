using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainmenu : MonoBehaviour
{
    public string url;
    public void P1VS2()
    {
        SceneManager.LoadScene(1);
    }
    public void P1VS3()
    {
        SceneManager.LoadScene(2);
    }
    public void P1VS4()
    {
        SceneManager.LoadScene(3);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT !");
        Application.Quit();
    }   
    public void Openurl()
    {
        Application.OpenURL(url);
    }   
    }
