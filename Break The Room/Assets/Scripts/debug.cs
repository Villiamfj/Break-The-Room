﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{
    // Start is called before the first frame update
    bool Check = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Debug.Log(Check);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Check = true;
    }

}
