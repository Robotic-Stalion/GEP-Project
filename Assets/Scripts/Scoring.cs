using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{

    public GameObject scoreText;
    public static int Score;
    public static int endScore = 50;
    
    //when end score is met the scene will change to the win screen
    void OnTriggerEnter(Collider other)
    {
        // the score text on the ui will add 1 each time an point is picked up and will destroy the object on collision
        Score += 1;
        Destroy(gameObject);
        scoreText.GetComponent<Text>().text = "SCORE: " + Score;

        // if the score is equal to the endscore the scene change will happen
        if (Score >= endScore)
        {
            SceneManager.LoadScene(2);
        }
    }
    
    void update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + Score; 
    }
    
    
}

