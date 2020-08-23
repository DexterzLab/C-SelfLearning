using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// to implement an interface, we use a comma(,) followed by the name of the interface
// The useful things about interfaces is that there can be multiple inheritance of interfaces
//in one script. It also helps when a designer needs to quickly code the characteristics
//of an object.
public class InterfacePlayer : MonoBehaviour, InterfaceScript, GenericInterface<float>
{
    public int Health { get; set; }

    public void Damage(int dmg)
    {
        Health -= dmg;
    }

    public void Damage(float dmg)
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
