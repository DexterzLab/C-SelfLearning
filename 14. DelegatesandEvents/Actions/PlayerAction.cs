using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// We are going to be working with actions. They are identical to delegates and events
/// but instead of initialisation with two lines, with a delegate then event, we do it with one.
/// 
/// To use actions we need to declare the namespace which is 'System'
///
/// </summary>

public class PlayerAction : MonoBehaviour
{
    //UIAction myaction;
    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamage;



    //first we create a delegate thats going to manage and handle  when we take dmg
    //instead of delegate we call an action, but is still a 'delegate void' signature
    //however we do need to declare a  <>'T bracket' which would hold the type 
    //of variable you are refering to 
    public static Action<int> OnDamageReceived;

    public int Health { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        Health = 10;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage();
        }
    }

    void Damage()
    {
        Health--;

        //normally we would have to reference the script to deal damage, myaction.UpdateHealth(Health);
        //but its not optimal


        //a better way is for the UImanager is to just listen for when the player has 
        //been damaged
        if(OnDamageReceived != null)
        {
            OnDamageReceived(Health);
        }

    }
}
