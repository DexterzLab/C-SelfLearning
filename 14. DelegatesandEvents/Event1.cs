using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// Events are specialised delegates, they create a broadcast system that allows other
/// classesa and objects to subscribe(listen) or desubcribe(not listen) to our delegates
/// 
/// This enables objects to carry out functionality without having to retrieve a reference
/// from another object. They can all simply listen for the message(or method) that is broadcast
/// This helps getting functionality to multiple objects without having to use a foreach/for loop
/// 
/// Events cannot be called independently in start or awake and only update because it needs
/// a constant signal at runtime.
/// 
/// </summary>


public class Event1 : MonoBehaviour
{
    //lets say we wanted to turn all 3 cubes to turn red at the click of a button

   //first you need to create a 'delegate' and 'event' variable which both need to be
   //the same name
   public delegate void ActionClick();

   //create an evenet to allow the cubes to subscribe to the button click
   public static event ActionClick onClick;

   public void ButtonClick()
   {
        //turn all cubes red

        //we need to check if its null otherwise it will pull and error
        //so we need to check if a object is listening to the broadcast

        //now the button has been clicked it will broadcast a onclick message
        //which other scripts can choose to listen to or not listen to,
        //then implement a function if they have recieved that message
        if (onClick != null)
            onClick();

        Debug.Log("broadcasting");




    }


}
