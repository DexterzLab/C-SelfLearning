using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// Now we are going to look at funtction/return delegates, which are new syntax.
/// 
/// Instead of making a void delegate you can assign a return value such as a string.
/// 
/// LAMBDA EXPRESSIONS
/// To make the most out of delegates we would use a lambda expression, which
/// allow use to write methods in line
/// 
/// 
/// </summary>


public class ReturnDelegate : MonoBehaviour
{

    //create a program that takes in a string and returns the length of it. (How many characters)
    
    //To create a return delegate the keywords would be in the same order if you was to do it the basic way.
    public delegate int CharacterLength(string text);
    CharacterLength cl;

    //To create a func type delegate we need to declare namespace system
    //Then use Func<type of result> which is a delegate which returns a result
    //If we wanted to pass in a parameter but return an int, we would use: 
    public Func<string, int> characterLength;

    private void Start()
    {

        //----------using the return type---------------
        //now to initialise it as a variable and have it hold a function with the same return type variables: CharacterLength cl = new CharacterLength(GetCharacters);

        //or you could initialise it out of scope and it work the same way: cl = GetCharacters;
        

        //now we can use the return delegate as you would with a normal return method.
        //Debug.Log(cl("Jon"));



        //---------using the func type---------------
        //now subcribe our intentional method
        //characterLength = GetCharacters;

        //then use it as a normal return method
        //int count = characterLength("jon");
        //Debug.Log("counter: " + count);





        //-----------USING LAMBDA EXPRESSIONS-------------------
        //Using a lamba expression will allow us to not rely on a seperate method, out of the current scope.

        //to declare a lambda we need to provide the parameters first, using a parameter first, then using '=>' which means 'go to'
        //then take the parameter variable<name> that we past in and return its length.

        //this one line is now identical to the return type method getcharacters
        characterLength = (name) => name.Length;

        int count = characterLength("jon");
        Debug.Log("counter: " + count);

    }
    /*
    int GetCharacters(string name)
    {
        return name.Length;
    }
    */










    /*--------------this would be the normal way of a return function

    void Start()
    {

        int charactercount = GetCharacters("Johnathan");
        Debug.Log("count: " + charactercount);
    }

    int GetCharacters(string name)
    {
        return name.Length;
    }

    */

}
