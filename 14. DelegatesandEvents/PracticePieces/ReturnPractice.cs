using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ReturnPractice : MonoBehaviour
{

    //create a delegate of type int that returns the length of the gameobjects name
   
    //if its a void delegate we use action, but a return delegates use func
    public Func<int> onGetName;

    private void Start()
    {
        onGetName = () => this.gameObject.name.Length;

        int charactercount = onGetName();

        Debug.Log("the count is: " + charactercount);
    }




}
