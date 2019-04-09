using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Check);
        //Debug.Log(Rb.velocity);
        try
        {
            if (transform.parent.gameObject.name == "RightHand")
            {
                Debug.Log(transform.parent.gameObject.GetComponent<Rigidbody>().velocity);
            } 
        }
        catch
        {
            //Debug.Log("off");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

    }

}
