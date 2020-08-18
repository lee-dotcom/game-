using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instance;
    public int currentscore = 0;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

    }

    // Update is called once per frame
    // Update is called once per frame

    void Update()

    {

        score.text = currentscore + "";

    }



    public void AddScore()

    {

        currentscore++;

    }



    public void RestartGame()

    {

        SceneManager.LoadSceneAsync(0);

    }

}

