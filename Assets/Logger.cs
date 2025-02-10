using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR.Hands;

public class Logger : MonoBehaviour
{
    [SerializeField] private XRHandTrackingEvents _rightHandTracker = null;

    private void Start()
    {
        //_rightHandTracker.m_TrackingAcquired += () => { Debug.Log("TRACKING ACQUIRED"); }
    }

    private void Update()
    {

    }

    public void Log(string message)
    {
        UnityEngine.Debug.Log(message);
    }
}
