using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour
{
// declare main menu button
    public Button mainMenu;
    //declare exit game button
    public Button exitButton;
    //declare resume button
    public Button resume;
    //declare restart Level button
    public Button restartLevel;
    
    public string thisGameSceneName;
    public string firstGameSceneName;
    public string gameSceneName;
    //public Button pause;
    public GameObject PauseMenuOnOff;

    //declare boolean isPaused and set to false
    public static bool isPaused = false;

    // Start is called before the first frame update
    void Awake()
    {
        //sets pausemenuonoff to false
        PauseMenuOnOff.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                //calls the resumeGame method
                ResumeGame();
            }
            else
            {
                //calls the Pause Game Method
                PauseGame();
            }
        }


    }
    //pause game function
    void PauseGame()
    {
        Time.timeScale = 0; //pause time in the game
        //sets pausemenuonoff to true
        PauseMenuOnOff.SetActive(true);
        //stes ispaused to true
        isPaused = true;

        mainMenu.onClick.AddListener(LoadGameScene);
        exitButton.onClick.AddListener(OnApplicationQuit);
        resume.onClick.AddListener(ResumeGame);
        restartLevel.onClick.AddListener(ReStartLevel);


    }
    //resumeGame method
    void ResumeGame()
    {
        Time.timeScale = 1; //unpause the game
        PauseMenuOnOff.SetActive(false); //
        isPaused = false; //set boolean to false
    }
    
  //
    public void LoadGameScene()
    {
        //loads the main menu
        GameSceneManager.Instance.LoadScene(gameSceneName);
    }

    //Restart level function
    public void ReStartLevel()
    {
        //reloads the current level
        GameSceneManager.Instance.LoadScene(thisGameSceneName);
        Time.timeScale = 1;
    }
    //onApplication Quit function
    private void OnApplicationQuit()
    {
        //quit application
        Application.Quit();
    }
}