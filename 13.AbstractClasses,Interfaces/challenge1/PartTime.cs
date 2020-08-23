using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTime : EmployeeAbstract
{
    public int hoursWorked;
    public int hourlyRate;
    public int salary;

    // Start is called before the first frame update
    void Start()
    {
       // Companyname = "aasd";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }
}
