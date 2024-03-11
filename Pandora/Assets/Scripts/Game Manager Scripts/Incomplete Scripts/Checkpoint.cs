using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
private LevelManager lm;
 

    void onTriggerEnter2D(Collider2D other)
    {

       //if player collides with checkpoint
        if(other.CompareTag("Player")){

         //sets SavelastCheckPointActivated to current player position
        lm.SaveCheckpoint (transform.position);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
         lm = FindObjectOfType<LevelManager>();
    }
 
}
