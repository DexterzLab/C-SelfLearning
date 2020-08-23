using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPlayer : MonoBehaviour
{
    public delegate void OnDeath();
    public static event OnDeath onDeath;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Death();
        }
    }


   
    void Death()
    {
        //GameObject.FindObjectOfType<EventManager>().ResetPlayer();
        //GameObject.FindObjectOfType<EventUI>().UpdateDeathCount();
        //a better optimised version of this code is so
        //that the player does not have to inform multiple objects about if it has died

        //instead we will broadcast a message saying we have died
        if (onDeath != null)
        {
            onDeath();
        }
    }
}
