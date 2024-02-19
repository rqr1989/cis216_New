using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //declare buttons startButton, continueButton and exitButton
    public Button startButton;
    public Button exitButton;
    
    public Button continueButton;

    //declare gameSceneName string
    public string gameSceneName;

    // Start is called before the first frame update
    void Start()
    {

        startButton.onClick.AddListener(LoadGameScene); // start new game

        exitButton.onClick.AddListener(OnApplicationQuit); //exits game

        //continueButton.onClick.AddListener(); //loads saved game


    }
    //onApplicationQuit function
    private void OnApplicationQuit()
    {
        //quits the game
        Application.Quit();
    }

    // Update is called once per frame

//LoadGameScene function
    public void LoadGameScene()
    {
        //starts a new play through
        GameSceneManager.Instance.LoadScene(gameSceneName);
    }
}
