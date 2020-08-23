using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class ItemLinq
{
    public string name;
    public int ID;
    public int buff;
}

public class LinqExercise2 : MonoBehaviour
{

    //how to filter through a list of classes/objects using linq

    public List<ItemLinq> myitem;

    // Start is called before the first frame update
    void Start()
    {

        //check if item id 3 exists and print true or false
        var selectItem = myitem.Any(item => item.ID == 3);
        Debug.Log(selectItem);

        //grab all items with a buff greater than 20
        var selectItem2 = myitem.Where(item => item.buff > 20);
        foreach (var item in selectItem2)
        {
            Debug.Log(item.name + " has a greater buff than 20");

        }


        //calculate the average of buff stats
        var selectItem3 = myitem.Average(item => item.buff);

        Debug.Log(selectItem3 + "is your average buff");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
