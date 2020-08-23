using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelPractice : MonoBehaviour
{
    //create a delegatre of type void that calculates he sum of two numbers.
    //Use Lambdas to avoid having a dedicated method

    //a variable which holds a function which takes in a parameter of 2 integers
    public Action<int, int> Sum;

    private void Start()
    {
        //state what function to hold
        // Sum = calcualte;

        //if the method is of type void then you can use the curly braces for a lambda
        Sum = (a, b) =>
        {

            var total = a + b;

            if (total < 100)
            {
                Debug.Log("you are lower than 100");
            }

            Debug.Log("total: " + total);
        };

        Sum(5, 2);
    }

  



}
