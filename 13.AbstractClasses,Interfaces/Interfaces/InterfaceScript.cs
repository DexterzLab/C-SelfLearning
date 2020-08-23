using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 'Interface' types are similar to abstract classes as they can force implementation
/// however these wont allow implementations and cannot contain fields. 
/// 
/// You can only use methods and properties
/// 
/// They allow polymorphism
/// 
/// we cant use public or private fields in interfaces as everything is already assumed public
/// 
/// </summary>
public interface InterfaceScript 
{

    //If we wanted to create a universal health system, and have the player 
    //and enemies have unique health implementations, but we want to make sure 
    //that they all have the concept of health and all have a damage method, we would use a interface.

    //to declare an interface we change the script from a class to an interface
    
    //interfaces follow a contract method, where the object that is using this interface
    //needs to have the exact variable that is initialised in this script

    int Health { get; set; }

    void Damage(int damageamount);

    //polymorphism allows a variable/function to have several forms
    //for example, we can have a second Damage() function which holds an float value

    //void Damage(float damageAmount);

    //and in order to get the ability to choose we need to assign the interface 
    //as a variable inside a method, for example:
    /*if(whatever)
     * {
     * 
     * InterfaceScript obj = hitinfo.collider.GetComponent<InterfaceScript>();
     * 
     * obj.Damage(float or int)
     */

}
