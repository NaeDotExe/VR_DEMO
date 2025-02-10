using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Hands;

public class HandsActivator : MonoBehaviour
{
    private XRHandSubsystem handSubsystem;

    void Start()
    {
        List<XRHandSubsystem> subsystems = new List<XRHandSubsystem>();
        SubsystemManager.GetSubsystems(subsystems);

        if (subsystems.Count > 0)
        {
            handSubsystem = subsystems[0];
            handSubsystem.Start(); 
            Debug.Log("XRHandSubsystem ok !");
        }
        else
        {
            Debug.LogError("no subsystem.");
        }
    }
}

