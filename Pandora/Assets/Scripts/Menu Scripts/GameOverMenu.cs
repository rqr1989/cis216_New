using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{ 
    //declare buttons : continueButton, mainMenu, exitButton
    public Button continueButton;
    public Button mainMenu;
    public Button exitButton;
    //decalre boolean playerdead
    public bool playerDead;
    //decalre string gameSceneName
    public string gameSceneName;
    
   //declare GameObject GameOverMenuOnOff
    public GameObject GameOverMenuOnOff;
    //declare boolean isGameOver and sets to false
    public static bool isGameOver = false;

    // Start is called before the first frame update
    void Awake()
    {

        GameOverMenuOnOff.SetActive(false);// sets Gameover menu on/off to false

        isGameOver = false; //sets isGameOver boolean to false

        mainMenu.onClick.AddListener(LoadGameScene); //main menu button loads main menu on click

        exitButton.onClick.AddListener(OnApplicationQuit); //quits game

       // continueButton.AddListener();//loads save
    }
 

    public void TurnOnGameOver()
    {
        //sets gameObject to true
        gameObject.SetActive(true);

        Time.timeScale = 0; //pause time in the game

        GameOverMenuOnOff.SetActive(true); //turn on Game Over Menu

        isGameOver = true; //set isGameOver boolean to true

    }

//LoadGame Scene function
    public void LoadGameScene() //loads main menu
    {
        //loads the main menu
        GameSceneManager.Instance.LoadScene(gameSceneName);
    }

//Load Auto Save function
    public void LoadAutoSave() //loads the most recent save
    {

    }
//onApplication Quit function
    private void OnApplicationQuit()
    {
        //quit application
        Application.Quit();
    }
}