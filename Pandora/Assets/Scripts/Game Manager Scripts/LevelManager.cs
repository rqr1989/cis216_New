using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //declare levelsUnlocked
    int levelsUnlocked = 1;

    //declare checkpointsUnlocked
    int checkpointsUnlocked = 0;

    //holds the transform value
    public Vector3 lastCheckPointActivated;

    //declare boolean levelWon and set to false
    bool levelWon = false;
    
    //need fixing a placeholder value
   public int playerStartPos = 0;
  
    //levelWon function
    public void levelIsWon()
    {
        //set levelWon to true
        levelWon = true;
    }
    //start function
    void Start()
    {
        //sets levelsUnlocked to integer stored in Player preferences. If no int is stored the value is 1
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);

        //check last checkpoint unlocked.If no integer is store set equal to 0
        checkpointsUnlocked = PlayerPrefs.GetInt("checkpointsUnlocked", 0);

        //calls levelLoad function to load the level indicated by levelsUnlocked 
        levelLoad();

        checkpointLoad();
        
     

    }


    //loadLevel function
    public void loadLevel(int levelNum)
    {
        //load the level
        SceneManager.LoadScene(levelNum);
    }
    //update function
    void Update()
    {
        if (levelWon)
        {
            // Reset checkpoint to 0
            checkpointsUnlocked = 0;

            // Unlock next level if not the final level
            if (levelsUnlocked < 9)
            {
                //increment level
                levelsUnlocked++;

                //save new value to levelsUnlocked
                PlayerPrefs.SetInt("levelsUnlocked", levelsUnlocked);
            }
            else
            {
                // Load credits scene if it's the final level
                SceneManager.LoadScene(10);
            }

            // Reset level won
            levelWon = false;
        }
    }
      
     

//level load function
public void levelLoad()
    {
        //load last level unlocked
        SceneManager.LoadScene(levelsUnlocked);
    }
public void checkpointLoad()
    {

        switch (checkpointsUnlocked)
        {
            case 1:
                playerStartPos = 1;
                break;
            case 2:
                playerStartPos = 2;
                break;
            case 3:
                playerStartPos = 3;
                break;
            case 4:
                playerStartPos = 4;
                break;
            default:
                playerStartPos = 0; // Default to beginning of level
                break;
        }
    }

    
    public void SaveCheckpoint(Vector3 checkpointPosition)
    {
        lastCheckPointActivated = checkpointPosition;
        checkpointsUnlocked = 0; // Assuming you want to unlock at least the first checkpoint upon activation
        PlayerPrefs.SetInt("checkpointsUnlocked", checkpointsUnlocked);
    }
}