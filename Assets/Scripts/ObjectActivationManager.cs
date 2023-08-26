using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivationManager : MonoBehaviour
{
    public GameObject[] Machines;

    public void SwitchMachines(string machineName)
    {
        foreach (GameObject machine in Machines)
        {
            if (machine.name == machineName)
            {
                machine.SetActive(true);
            }
            else
            {
                machine.SetActive(false);
            }
        }
    }
}
