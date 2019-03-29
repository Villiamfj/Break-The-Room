using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Destrucktable : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody Rb;
    Rigidbody ORb;
    public float V;
    public GameObject Spawnee;
    void Start()
    {
        Rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        try
        {
            if (collision.transform.parent.gameObject.name == "RightHand")
            {
                GameObject Rhand = GameObject.Find("Righthand");
                if (Rhand.GetComponent<Rigidbody>().velocity.magnitude > V)
                {
                    if (collision.gameObject.tag == "Des")
                    {
                        Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                        Destroy(collision.gameObject);
                    }
                    if (gameObject.tag == "Des")
                    {
                        Instantiate(Spawnee, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                        Destroy(gameObject);
                    }
                }
            }

            if (collision.transform.parent.gameObject.name == "LeftHand")
            {
                GameObject Lhand = GameObject.Find("LeftHand");
                if (Lhand.GetComponent<Rigidbody>().velocity.magnitude > V )
                {
                    if (collision.gameObject.tag == "Des")
                    {
                        Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                        Destroy(collision.gameObject);

                    }
                    if (gameObject.tag == "Des")
                    {
                        Instantiate(Spawnee, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                        Destroy(gameObject);

                    }
                }

            }
        }
        catch
        {
            try
            {
                ORb = collision.rigidbody;
                if (ORb.velocity.magnitude > V || Rb.velocity.magnitude > V)
                {
                    if (collision.gameObject.tag == "Des")
                    {
                        Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                        Destroy(collision.gameObject);


                    }
                    if (gameObject.tag == "Des")
                    {
                        Instantiate(Spawnee, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                        Destroy(gameObject);

                    }
                }

            }
            catch
            {
                if (Rb.velocity.magnitude > V)
                {
                    if (collision.gameObject.tag == "Des")
                    {
                        Destroy(collision.gameObject);
                    }
                    if (gameObject.tag == "Des")
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
}
