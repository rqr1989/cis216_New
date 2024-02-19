using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class LevelManager : MonoBehaviour
{
    //declare levelsUnlocked
    int levelsUnlocked;

    //declare checkpointsUnlocked
    int checkpointsUnlocked;

    //declare boolean levelWon and set to false
    bool levelWon = false;
    
    
//levelWon function
 public void levelIsWon(){
    //set levelWon to true
    levelWon = true;
 }   
    //start function
    void Start()
    {
        //sets levelsUnlocked to integer stored in Player preferences. If no int is stored the value is 1
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked",1);

       //check last checkpoint unlocked.If no integer is store set equal to 0
       checkpointsUnlocked = PlayerPrefs.GetInt("checkpointsUnlocked",0);

    //calls levelLoad function to load the level indicated by levelsUnlocked 
       levelLoad();
    }


//loadLevel function
public void loadLevel (int levelNum)
{
    //load the level
    SceneManager.LoadScene(levelNum);
}
//update function
   void Update ()
   {
     //if levelWon equals true
if (levelWon == true) {
    //and if levelsUnlocked is less than 9
if (levelsUnlocked < 9) {
    
    //increment levelsUnlocked by one
    levelsUnlocked++;   

    //save new value to levelsUnlocked
    PlayerPrefs.SetInt("levelsUnlocked", levelsUnlocked);
}
    else if (levelsUnlocked > 9){

    //load the credits scene
     SceneManager.LoadScene(10);
    }

    //sets levelWon back to false
        levelWon = false;

}

   }

//level load function
   void levelLoad(){

//if levelsUnlocked is less than or equal to 1
    if(levelsUnlocked >= 1){
        //load level 1
        SceneManager.LoadScene(1);
    }
    //else if levelsUnlocked equals 2
    else if (levelsUnlocked == 2){

        //load level 2
         SceneManager.LoadScene(2);
    }

    //else if levelsUnlocked equals 3
  else if (levelsUnlocked == 3){

    //load level three
      SceneManager.LoadScene(3);
       }

    //else if levelsUnlcoked equals 4
    else if (levelsUnlocked == 4){
    
    //load level 4
    SceneManager.LoadScene(4);
    }

     //else if levelsUnlocked equals 5
    else if (levelsUnlocked == 5){
    
    //load level five
     SceneManager.LoadScene(5);
    }

     //else if levelsUnlocked equals 6
     else if (levelsUnlocked == 6){
   
    //load level six
    SceneManager.LoadScene(6);
   }

     //else if levelsUnlocked equals 7
    else if (levelsUnlocked == 7){
    
    //load level seven
    SceneManager.LoadScene(7);
    }
     //else if levelsUnlocked equals 8
    else if (levelsUnlocked == 8){
    //load level eight
    SceneManager.LoadScene(8);
    }
     //else if levelsUnlocked equals 9
    else if (levelsUnlocked == 9){

    //load level nine
     SceneManager.LoadScene(9);
    }
  

   }
}
