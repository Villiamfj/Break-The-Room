using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{
    // Start is called before the first frame update
    bool Check = false;
    Rigidbody Rb;
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Check);
        Debug.Log(Rb.velocity);

    }
    private void OnCollisionEnter(Collision collision)
    {
        Check = true;
    }

}
