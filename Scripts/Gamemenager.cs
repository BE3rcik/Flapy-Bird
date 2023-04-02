using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemenager : MonoBehaviour
{
    public Text PointsText;
    public int Point = 0;
    public GameObject gameOverScreen;
    public BirdScript Bird;
    public GameObject Score;
    public Text EndPointsText;
    public Text EndHaighScoreText;
    public AudioSource src;
    public AudioClip End,Click;

    void Start()
    {
  
        gameOverScreen.SetActive(false);
        Score.SetActive(true);
        EndHaighScoreText.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    
    void Update()
    {
        if(Bird.isAlive == false)
        {
            
            Score.SetActive(false);
            EndPointsText.text = Point.ToString();
            if(Point > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", Point);
                EndHaighScoreText.text = Point.ToString();

            }
            
        }
    }
    public void addScore(int Score)
    {
        if(Bird.isAlive == true)
        {
            
           Point = Point + Score;
           PointsText.text = Point.ToString();

        }
        
    }
    public void LoadLevel()
    {
        src.clip = Click;
        src.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        src.clip = End;
        src.Play();
        gameOverScreen.SetActive(true);
    }
    public void BackMenu()
    {
        src.clip = Click;
        src.Play();
        SceneManager.LoadScene(0);
    }
}
