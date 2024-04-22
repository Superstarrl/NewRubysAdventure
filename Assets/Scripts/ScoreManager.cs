using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCount;
    public static bool isDead;
    public GameObject winTextObject;
    public GameObject loseTextObject;


    // Start is called before the first frame update
    void Start()
    {
        winTextObject.SetActive(false) ;
        loseTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Fixed Robots: " + scoreCount;
       
        //score is updated in rubycontroller
        if (scoreCount >= 2) 
        {
            winTextObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Y))
            {
                Reboot();
            }
        }

        //death status is set true in rubycontroller
        if (isDead) {
            loseTextObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Y))
            {
                Reboot();
            }
        }   
    }

    void Reboot()
    {
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
        scoreCount = 0;
        isDead = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }     
}