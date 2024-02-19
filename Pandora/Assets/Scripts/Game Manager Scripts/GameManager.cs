using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//if player wins load next scene
public class GameManager : MonoBehaviour
{
   
    public string gameSceneName;
    public string MainMenu;



    public bool playerwins; //boolean to determine if player won the level
                            
           
             
    // LoadGameScene method
    public void LoadGameScene()
    {

        GameSceneManager.Instance.LoadScene(gameSceneName);
    }
    
    // LoadMainMenu method
    public void LoadMainMenu()
    {

        GameSceneManager.Instance.LoadScene(MainMenu);
    }
 
  

}