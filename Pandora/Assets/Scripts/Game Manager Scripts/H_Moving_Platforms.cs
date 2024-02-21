using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_Moving_Platforms : MonoBehaviour
{

    [SerializeField] private Transform rightedge;
    [SerializeField] private Transform leftedge;

    [Header("Platform")]
    [SerializeField] private Transform platform;

    [Header("Movement Parameters")]
    [SerializeField] private float speed;
    private Vector3 initScale;
    private bool movingLeft;

    [Header("Idle Time")]

    [SerializeField] private float idleDuration;
    private float idleTimer;
    private void Awake()
    {
        initScale = platform.localScale;
    }

    //
    void Update()
    {
        //if the platform is movingLeft
        if (movingLeft)
        //and if the platform position on the x axis is greater than or equal to the left edge pos X
        {
            if (platform.position.x >= leftedge.position.x)
            {
                //call MoveInDirection function and pass -1 as parameter
                MoveInDirection(-1);
            }
            else
            {
                //call DirectionChange function
                DirectionChange();
            }

        }
        else
        //if (platfom pos in X axis is less than pr equal to rightedge pos X
           if (platform.position.x <= rightedge.position.x)
        {
            //Call Move in Direction and pass 1 as argument
            MoveInDirection(1);
        }
        else
            //call DirectionChange function tochange direction
            DirectionChange();
    }
    //MoveInDirection function
    private void MoveInDirection(int _direction)
    {
        //set idle timer to 0
        idleTimer = 0;

        //makes platform move in direction
        platform.position = new Vector3(platform.position.x + Time.deltaTime * _direction * speed, platform.position.y,
             platform.position.z);
    }
    //DirectionChange function
    private void DirectionChange() //change direction of platform
    {
        //set idleTimer equal to current value plus Time.deltaTime
        idleTimer += Time.deltaTime;
        //if idleTimer is greater than idleDuration
        if (idleTimer > idleDuration)
        {
            //set movingleft equal to not moving Left
            movingLeft = !movingLeft;
        }

    }
}
