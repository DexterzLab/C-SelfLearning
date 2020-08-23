using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqChallenge : MonoBehaviour
{
    //create an int array of grades between 0-100
    //filter through and create a new collection of only the passing grades

    public int[] grades = { 0, 12, 25, 34, 53, 66, 78, 74, 83, 85, 90, 100 };


    // Start is called before the first frame update
    void Start()
    {

        //var passedStudents = grades.Where(grade => grade > 69);

        var passedStudents = grades.Where(grade => grade > 69).OrderByDescending(grade => grade);

        foreach (var student in passedStudents)
        {
            Debug.Log("passing scores: " + student);
        }
    }

   
}
