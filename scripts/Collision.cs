using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collision : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject scoreText;   
    public static bool gamePause;    
    

    public void newGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gamePause = false;
        scoreText.SetActive(true);

    }

    private void Start()
    {
        scoreText.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       

        if(collision.collider.tag == "Box")
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            gamePause = true;
        }
    }
}
