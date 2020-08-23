using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ReturnPractive_WithParam : MonoBehaviour
{
    //it is always easier to do the old way first so you can clearly see how to convert it
    //if its a void delegate we use action, but a return delegates use func

    //create a delegate of type int that takes 2 numbers as a parameter and adds the sum

    public Func<int,int, int> mySum;

    private void Start()
    {
        

        mySum = (a, b) => { return a + b; };
        
        

        Debug.Log(mySum(5, 5));
    }




}
