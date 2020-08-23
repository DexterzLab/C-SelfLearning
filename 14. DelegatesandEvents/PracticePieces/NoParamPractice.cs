using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoParamPractice : MonoBehaviour
{
    //create a delegate of type void that has no parameters and returns the gameObjects name
    public Action onGetName;

    private void Start()
    {
        onGetName = () => Debug.Log("Name: " + gameObject.name);

        onGetName();
    }



}
