using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsMenu : MonoBehaviour
{ 
    //declare buttons : mainMenu, exitButton
    public Button mainMenu;
    public Button exitButton;
  
    //decalre string gameSceneName
    public string gameSceneName;
    
   //declare GameObject GameWonMenuOnOff
    public GameObject GameWonMenuOnOff;
    //declare boolean isGameWon and sets to false
    public static bool isGameWon = false;

    // Start is called before the first frame update
    void Awake()
    {

        GameWonMenuOnOff.SetActive(false);// sets GameWon menu on/off to false

        isGameWon = false; //sets isGameWon boolean to false

        mainMenu.onClick.AddListener(LoadGameScene); //main menu button loads main menu on click

        exitButton.onClick.AddListener(OnApplicationQuit); //quits game

        
    }
 

    public void TurnOnGameWon()
    {
        //sets gameObject to true
        gameObject.SetActive(true);

        Time.timeScale = 0; //pause time in the game

        GameWonMenuOnOff.SetActive(true); //turn on Game Won Menu

        isGameWon = true; //set isGameWon boolean to true

    }

//LoadGame Scene function
    public void LoadGameScene() //loads main menu
    {
        //loads the main menu
        GameSceneManager.Instance.LoadScene(gameSceneName);
    }


//onApplication Quit function
    private void OnApplicationQuit()
    {
        //quit application
        Application.Quit();
    }
}
