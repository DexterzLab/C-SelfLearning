using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CallbackSystem : MonoBehaviour
{

    //Notify the user the routine has finished using a delegate


    // Start is called before the first frame update
    void Start()
    {
        //enter a no parameter'()' bracket along with the 'goto' symbol
        //now you can enter whatever logic needed to play after the five seconds

        //we enter a no parameter delegate, followed by the go to statement
        StartCoroutine(MyRoutine( () =>
        {
            Debug.Log("the routine has finished");
        }));
    }


    //i want to be notified after the routine has finished

    //pass in a delegate as a parameter but assign it as null, to make the parameter as optional
    public IEnumerator MyRoutine(Action onComplete = null)
    {
        yield return new WaitForSeconds(5f);

        //make sure someone is lsitening
        //broadcast after the five seconds is done
        if(onComplete != null)
        {
            onComplete();
        }

        
    }
}
