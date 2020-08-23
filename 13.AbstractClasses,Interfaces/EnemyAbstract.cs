using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//making classes abstract no longer makes using certain methods optional
//and you can no longer attach the script to an object, it can only be used through
//inheritence
//this is useful as it creates a partial template to define what is going on =

public abstract class EnemyAbstract : MonoBehaviour
{
    public int speed;
    public int health;
    public int gems;

    //in order to force a method we need to make it abstract
    //also abstract methods do not have implementations, so you cannot use curly brackets
    //and can only initialise them
    public abstract void Attack();

    //abstract classes can still contain virtual methods
    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
   
}

//if this class does not contain the methods that are abstract it will return an error
public class MossGiant : EnemyAbstract
{
   

    private void Start()
    {
        
    }

    public override void Attack()
    {
        throw new System.NotImplementedException();

        
    }
    
    //now you can call your own version of die while still keeping the base implementation
    //of what you've written for a character dying
    //but now you can add additional instructions without disrupting other scripts using the 
    //same inhereted method
    public override void Die()
    {
        Debug.Log("giant has died");
        base.Die();
       
    }
}