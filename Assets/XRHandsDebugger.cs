using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Hands;
using UnityEngine.XR.OpenXR.Features;

public class XRHandsDebugger : MonoBehaviour
{
    void Start()
    {
        //var subSystem = XRHandSubsystem.get

        List<XRHandSubsystem> subsystems = new List<XRHandSubsystem>();
        SubsystemManager.GetSubsystems(subsystems);

        if (subsystems.Count > 0)
        {
            Debug.Log($"XRHandSubsystem trouvé ! Nombre : {subsystems.Count}");
        }
        else
        {
            Debug.LogError("Aucun XRHandSubsystem trouvé !");
        }
    }

    void Update()
    {

    }
}
