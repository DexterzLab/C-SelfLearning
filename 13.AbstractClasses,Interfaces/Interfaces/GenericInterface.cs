using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// 
///   -------------------Generic interfaces-----------------   
/// Instead of having to implement all the functions because of its strict rule
/// you can give a class the ability to choose what type of function you using.
/// this is called a generic interfaces
/// 
/// when you declare the interface in another script you must include the brackets aswell
/// as the type you are using for the function
/// 
/// </summary>

//in order the class a script the ability to choose what type of variable to cast
//we need to create '<> Tbrackets' and put in the keyword 'T' for the interface and the function
//....yes T is a key word.


public interface GenericInterface<T>
{
    void Damage(T dmg);
}

