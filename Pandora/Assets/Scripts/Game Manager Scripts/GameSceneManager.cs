using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



//[RequireComponent (typeof (PlayerManager))]
//[RequireComponent (typeof (InventoryManager))]
//[RequireComponent (typeof (SaveDataManager))]

public class GameSceneManager : MonoBehaviour
{
     public static GameSceneManager Instance;
    public float uiLoadTime = 0.5f;
    private AsyncOperation asynOperation;
    

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        

    }


    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadNewScene(sceneName));
    }
    // 
    private IEnumerator LoadNewScene(string sceneName)
    {
        yield return null;
        //pauses anything run in update function
        Time.timeScale = 0f;

        yield return new WaitForSecondsRealtime(uiLoadTime);
        asynOperation = SceneManager.LoadSceneAsync(sceneName);
        while (!asynOperation.isDone)
        {
            yield return null; //wait single frame
        }
    }
}
   /* public static InventoryManager{get; private set;}
    public static SaveDataManager {get;private set;}
    public static PlayerManager {get; private set;}

    private List<IGameManager>_startSequence; //loop through list of game managers

    private void Awake()
    {
        
    
        //sets playerManager script equal to player
        Player = GetComponent<PlayerManagerlayerManager>();

       //sets inventoryManager script equal to Inventory
        Inventory = GetComponent<InventoryManager>();

       //sets SaveDatamanger equal to SavedData
        SavedData = GetComponent<SaveDataManager> ();

        _startSequence = new List<IGameManager>();//loop through Player,Inventory and SavedData managers
        _startSequence.Add(Player);
        _startSequence.Add(Inventory);
        _startSequence.Add(SavedData);

        StartCoroutine(StartupManagers ());


    }


private IEnumerator StartupManagers (){


//for every IGamManeger manager in the list
    foreach (IGameManager manager in _startSequence){

        manager.Startup();

    }
    //return null
    yield return null;

//declare numberOF Managers and set equal to the number of lsted maanagers in _startSequence
    int numberOfManagers =_startSequence.Count;
    Int numberReady = 0;

//while numberReady is less than numberOfManagers
    while (numberReady < numberOfManagers)
{
    //declare currentCount and set equal to numberReady
     int currentCount = numberReady;
    numberReady = 0;

    //for every IGamManeger manager in the list
    foreach(IGameManager manager in _startSequence){

        if(manager.status == ManagerStatus.Started){

            numberReady++; //increment numberReady by 1
        }

    }
   

}
} */

//}