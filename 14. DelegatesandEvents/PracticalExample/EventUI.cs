using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventUI : MonoBehaviour
{
    public int deathCount;
    public Text deathCountText;

    private void OnEnable()
    {
        EventPlayer.onDeath += UpdateDeathCount;
    }

    public void UpdateDeathCount()
    {

        deathCount++;
        deathCountText.text = "Death Count: " + deathCount;

    }
}
