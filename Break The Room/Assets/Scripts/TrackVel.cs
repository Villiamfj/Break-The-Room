using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TrackVel : MonoBehaviour
{
    public float v;
    SteamVR_Behaviour_Pose trackedObj;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        trackedObj = GetComponent<SteamVR_Behaviour_Pose>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(trackedObj.GetVelocity().magnitude);
        v = trackedObj.GetVelocity().magnitude;
    }
}
