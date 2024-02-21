using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Moving_Platforms : MonoBehaviour
{
    [SerializeField] private Transform topedge;
    [SerializeField] private Transform bottomedge;

    [Header("Platform")]
    [SerializeField] private Transform platform;

    [Header("Movement Parameters")]
    [SerializeField] private float speed;
    private Vector3 initScale;
    private bool movingUp;

    [Header("Idle Time")]
    [SerializeField] private float idleDuration;
    private float idleTimer;
    private void Awake()
    {
        initScale = platform.localScale;
    }

    //Adapt for vertical moving platform
    void Update()
    {
        if (movingUp)//if platform moving up
        {
            //if platform posotion y is greater than or equak to bottomedge position y
            if (platform.position.y >= bottomedge.position.y)
            {
                //call MoveInDirection function and pass -1 as argument
                MoveInDirection(-1);
            }
            else
            {
                // calls change direction
                DirectionChange();
            }

        }
        else
        //if platform pos Y is less than or equal to the top edge Y positio
            if (platform.position.y <= topedge.position.y)
        {
            //calls MoveInDirection functioin and passes 1 as an argument
            MoveInDirection(1);
        }
        else
            //change direction
            DirectionChange();
    }
    private void MoveInDirection(int _direction)
    {
        //set idleTimer to 0
        idleTimer = 0;

        //makes platform move
        platform.position = new Vector3(platform.position.x, platform.position.y + Time.deltaTime * _direction * speed, platform.position.z);
    }
    //Change Direction Functiom
    private void DirectionChange() //change direction of platform
    {

        idleTimer += Time.deltaTime;
        //if idleTimer is greater than idleDuration
        if (idleTimer > idleDuration)
        {
            //reverse direction
            movingUp = !movingUp;
        }

    }
}
