using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Hands;
using UnityEngine.SubsystemsImplementation;
using UnityEngine.XR.Management;
using UnityEngine.XR.OpenXR;
using UnityEngine.XR.Hands.OpenXR;

public class HandsActivator : MonoBehaviour
{
    private XRHandSubsystem handSubsystem;

    void Start()
    {
        CheckSubsytems();
    }

    private void CheckSubsytems()
    {
        var subsystems = new List<ISubsystem>();
        SubsystemManager.GetInstances(subsystems);

        Debug.Log("test");

        if (subsystems.Count > 0)
        {
            foreach (var subsystem in subsystems)
            {
                Debug.Log($"Sous-système détecté : {subsystem.GetType().FullName}");
            }
        }
        else
        {
            Debug.LogError("Aucun sous-système détecté !");
        }
    }

    private void ForceHandActivation()
    {
        handSubsystem = XRGeneralSettings.Instance.Manager.activeLoader.GetLoadedSubsystem<XRHandSubsystem>();

        if (handSubsystem != null)
        {
            handSubsystem.Start();
            Debug.Log("XR Hand Tracking activé !");
        }
        else
        {
            Debug.LogError("Impossible d’activer XR Hand Tracking !");
        }
    }

    private void Update()
    {
        if (handSubsystem == null)
        {
            List<XRHandSubsystem> list = new List<XRHandSubsystem>();
            SubsystemManager.GetSubsystems(list);

            if (list.Count > 0)
            {
                handSubsystem = list[0];
                Debug.LogFormat("right hand tracked ? {0}", handSubsystem.rightHand.isTracked);
            }
        }
    }
}

