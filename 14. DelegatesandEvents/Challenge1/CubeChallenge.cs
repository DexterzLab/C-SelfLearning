using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeChallenge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //the event serves as a mask for the spawn function. 
        //so the parameter your passing in will be used from the broadcast.

        //listen for the broadcast as soon as the game starts
        EventChallenge.onTeleport += Spawn;
    }

    //create a method that matches the position
    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
    }

    private void OnDisable()
    {
        EventChallenge.onTeleport -= Spawn;
    }

}
