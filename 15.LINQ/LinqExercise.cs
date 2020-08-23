using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// 
/// LINQ stands for language intergrated query, and it is similar to SQL in which
/// it can filter through data. Specifically through arrays and lists. 
/// 
/// In order to use a LINQ you need to declare the namespace which is System.Linq
/// 
/// </summary>


public class LinqExercise : MonoBehaviour
{

    public string[] names = { "jon", "alex", "julie", "jessie", "david", "jon" };



    // Start is called before the first frame update
    void Start()
    {

        //normally if we wanted to filter through data we would use a foreach loop 
        //but thats not effiecient if the array is 100+ items so instead we use a LINQ
        //so everything is on one line

        //the first LINQ method is called 'Any' which acts as a foreach loop 
        //using a lambda expression. So 'name' would be the item in names, and we check if 'name' contains the desired string.
        //var namesFound = names.Any(name => name == "jon");

        //the second method is called 'Contains' which only takes in one parameter returning true or false if theres a match, nice and simple
        //var namesFound = names.Contains("jon");

        //the third method is called 'Distinct', which removes all duplicate elements of a collection
        //and puts it in a new seperate list
        //majority of the time you will leave brackets empty as it will automatically read the list you set to modify.
        //you need to use a foreach loop in the end to see what has been collected as a duplicate
        /* var uniqueNames = names.Distinct();

         foreach (var name in uniqueNames)
         {
             Debug.Log("Duplicate list: " + name);
         }
         */

        //the fourth method is called 'Where' which allows us to create a new collection based on a condition
        var result = names.Where(name => name.Length > 5);

        foreach (var name in result)
        {
            Debug.Log("Name: " + name);
        }

       // Debug.Log("name is: " + namesFound);

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
