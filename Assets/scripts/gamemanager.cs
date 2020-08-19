using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour

{

    public static gamemanager instance;

    [Header("Main Player object")]

    [Tooltip("Drag the main player from the herarchy in here")]

    public playercontorroler player;



    [Header("Platform Variables")]

    [Tooltip("If you don't see the spaces to add the spawnPositions click the little arrow and type the number then enter")]

    public Transform[] spawnPositions;

    public Transform endPosition;



    [Header("Background Variables")]

    [Tooltip("End position of the background tiles")]

    public Transform endPosBG;



    int currentScore = 0;



    [Header("UI Elements")]

    public Text score;

    public GameObject gameOver;



    [HideInInspector]

    public cameracontroller cam;



    // Start is called before the first frame update

    void Start()

    {

        instance = this;

        cam = Camera.main.GetComponent<cameracontroller>();

    }



    // Update is called once per frame

    void Update()

    {

        score.text = currentScore + "";

    }



    public void AddScore()

    {

        currentScore++;

    }



    public void RestartGame()

    {

        SceneManager.LoadSceneAsync(0);

    }

}

