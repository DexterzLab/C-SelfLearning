using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //the good thing about delegates and events is that objects can behave individually

        //we will need to subscribe(listen) to our onclick event, by referencing the script 
        //that it is initialised in

        //The onclick function will now hold functionality of the turn red function
        //for this object/script only.
        Event1.onClick += TurnRed;
    }

    //we also need to register the delegate signature, so we create a void type for this example
    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    //you must remove the subscription(stop listening) to the broadcast if you are removing a object
    private void OnDisable()
    {
        Event1.onClick -= TurnRed;
    }

}
