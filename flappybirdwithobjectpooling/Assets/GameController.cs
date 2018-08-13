using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

    public static GameController instance;
    public Text scoreText;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    private int score = 0;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        else if(instance!=this)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(gameOver==true &&Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
    public void BirdScored()
    {
        if(gameOver)
        {

        }
        score++;
        scoreText.text = "Score : "+score.ToString();


    }
    
}
