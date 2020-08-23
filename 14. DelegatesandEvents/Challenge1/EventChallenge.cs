using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//-------------BROADCASTING SCRIPT-----------------
public class EventChallenge : MonoBehaviour
{

    //Create a program using delegates and events where you hit the space key and assign a cube
    //a position of (5,2,0)---the cube script should subscribe to the event and be invoked when you hit the space key

    //first create a delegate signiture thats going to be a method and accept a position
    public delegate void Teleport(Vector3 pos);
    public static event Teleport onTeleport;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            //check if a object is listening for a event
            if (onTeleport != null)
            {
                Vector3 pos = new Vector3(5, 2, 0);

                //this one is different as you are broadcasting that an object needs to 
                //move the position that we are broadcasting additional
                onTeleport(pos);
            }
                

            //Event1.onClick += MovePosition;

           
        }
        
    }
    /*
    void MovePosition()
    {
        transform.position = new Vector3(5, 2, 0);

    }
    */
}
