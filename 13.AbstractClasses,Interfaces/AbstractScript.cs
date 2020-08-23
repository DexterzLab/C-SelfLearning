using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// Absract classes and methods allow the user to force inheritence and create easily
/// managable and maintainable code.
/// 
/// For example if we had 3 enemy scripts all with attributes of speed, health and a attack method.
/// The problem with that is the code is duplicated so instead we want to force
/// inheritence on all of the enemy types
/// 
/// </summary>
public class AbstractScript : MossGiant
{

    //public MossGiant giant;

    // Start is called before the first frame update
    void Start()
    {

        Die();
        
       // giant.Die();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
