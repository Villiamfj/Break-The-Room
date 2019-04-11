using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class DestroyOnKeyPress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("Hair Trigger"))
        {
            Debug.Log("Kage");
        }
        
    }
}
