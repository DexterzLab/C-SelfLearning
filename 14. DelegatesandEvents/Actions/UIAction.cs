using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIAction : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerAction.OnDamageReceived += UpdateHealth;
    }

    public void UpdateHealth(int health)
    {
        //display update health here

        Debug.Log("current health: " + health);

    }
  
}
