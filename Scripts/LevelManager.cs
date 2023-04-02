using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject HTPMenu;
    public GameObject MainMenu;
    public AudioClip Click;
    public AudioSource src;

    private void Start()
    {
        src.clip = Click;
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
        src.Play();
    }
    public void QuitGame()
    {
        Application.Quit();
        src.Play();
    }
    public void NextMenu()
    {
        MainMenu.SetActive(false);
        HTPMenu.SetActive(true);
        src.Play();
    }
    public void PreviousMenu()
    {
        MainMenu.SetActive(true);
        HTPMenu.SetActive(false);
        src.Play();
    }
}
