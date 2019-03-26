using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (collision.transform.gameObject.name == "RightHand")
        {
            GameObject Rhand = GameObject.Find("Righthand");
            if (Rhand.GetComponent<Rigidbody>().velocity.x > V || Rhand.GetComponent<Rigidbody>().velocity.y > V || Rhand.GetComponent<Rigidbody>().velocity.z > V)
            {
                if (collision.gameObject.tag == "Des")
                {
                    Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                    Destroy(collision.gameObject);
                }
                if (gameObject.tag == "Des")
                {
                    Instantiate(Spawnee, new Vector3(transform.position.x,transform.position.y, transform.position.z), Quaternion.identity);
                    Destroy(gameObject);
                }
            }
        }

        if(collision.transform.parent.gameObject.name == "LeftHand")
        {
            GameObject Lhand = GameObject.Find("LeftHand");
            if (Lhand.GetComponent<Rigidbody>().velocity.x > V || Lhand.GetComponent<Rigidbody>().velocity.y > V || Lhand.GetComponent<Rigidbody>().velocity.z > V)
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
        

        try
        {
            ORb = collision.rigidbody;
            if (ORb.velocity.x > V || ORb.velocity.y > V || ORb.velocity.z > V || Rb.velocity.x > V || Rb.velocity.y > V || Rb.velocity.z > V)
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
            if (Rb.velocity.x > V || Rb.velocity.y > V || Rb.velocity.z > V)
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
