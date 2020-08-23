using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// A delegate is a variable that holds a method or several methods
/// Delegates are declared using the keyword 'delegate'
/// 
/// </summary>
public class Delegate1 : MonoBehaviour
{
    //first we need to define a signiture for our delegate, which will be a method
    //following by the type of variable to pass in
    public delegate void ChangeColor(Color newColor);

    //to use a delegate we create it as a variable
    public ChangeColor onColorChange;

    //to assign delegates to other functions the parameters need to match
    //otherwise you cannot use them

    public delegate void OnComplete();
    public OnComplete onComplete;


    //a standard method to implement a delegate
    //before we use a delegate we need to make sure the signatures match
    //and by signature I mean the keywords that are being implemented to create the function
    public void UpdateColor(Color newColor)
    {
        Debug.Log("changing color to " + newColor);

    }

    //error check method
    public void Task()
    {

        Debug.Log("Task finished");
    }
    //error check method
    public void Task2()
    {

        Debug.Log("Task2 finished");
    }
    //error check method
    public void Task3()
    {

        Debug.Log("Task3 finished");
    }

    private void Start()
    {
        //we can now use the delegate by assigning it to the indentical function
        onColorChange = UpdateColor;

        //now to invoke the delegate we use it as we would for a normal method
        onColorChange(Color.green);


        //one benefit to delegates is that they multicast functions at once
        //but first they need to be stored into the delegate
        onComplete += Task;
        onComplete += Task2;
        onComplete += Task2;
        //and they can also be removed
        onComplete -= Task3;

        //you must check if the delegate is empty otherwise it will throw and error
        if(onComplete != null)
            onComplete();
    }
}
