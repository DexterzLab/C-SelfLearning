using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private void OnEnable()
    {
        EventPlayer.onDeath += ResetPlayer;
    }
    public void ResetPlayer()
    {

        Debug.Log("ResettingPlayer");

    }
}
