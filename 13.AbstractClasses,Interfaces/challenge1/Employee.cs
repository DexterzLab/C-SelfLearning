using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EmployeeAbstract: MonoBehaviour
{

    public string Companyname;
    public string Employeename;

    public abstract void CalculateMonthlySalary();
   
}
