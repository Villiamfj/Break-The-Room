using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Destrucktable : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody Rb;
    Rigidbody ORb;
    public double ObjObjV = 3;
    public double HandV = 0.05;
    public GameObject Spawnee;
    public float GivenScore = 1;
    public GameObject SpawnedText;
    public Vector3 Offset = new Vector3(0, 0, 0);

    void Start()
    {
        Rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //"collision" = det obj man støder sammen med
    private void OnCollisionEnter(Collision collision)
    {
        
        //Hvis collision er højre hånd
        if (collision.gameObject.name == "RightHand")
        {
            GameObject Rhand = GameObject.Find("RightHand");
            if (Rhand.GetComponent<TrackVel>().v > HandV)
            {
                //Debug.Log("GUT PUNCH R");
                /*
                if (collision.gameObject.tag == "Des")
                {
                    Score();
                    Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                    Destroy(collision.gameObject);
                }
                */
                if (gameObject.tag == "Des")
                {
                    Score();
                    Destro();
                }
            }
        }
        //Hvis collison er venstre hånd
        if (collision.gameObject.name == "LeftHand")
        {
            GameObject Lhand = GameObject.Find("LeftHand");
            if (Lhand.GetComponent<TrackVel>().v > HandV)
            {
                //Debug.Log("GUT PUNCH L");
                /*
                if (collision.gameObject.tag == "Des")
                {
                    Score();
                    Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                    Destroy(collision.gameObject);

                }
                */
                if (gameObject.tag == "Des")
                {
                    Score();
                    Destro();
                }
            }
            
        }
        //------------------------------------------------------
        
        //hvis gameobject er holdt i hånden
        try
        {
            //hvis holdt i højre hånd
            if (transform.parent.gameObject.name == "RightHand")
            {

                GameObject Rhand = GameObject.Find("RightHand");
                if (Rhand.GetComponent<TrackVel>().v > HandV)
                {
                    Debug.Log("PARENT FOUND R");
                    /*
                    if (collision.gameObject.tag == "Des")
                    {
                        Score();
                        Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                        Destroy(collision.gameObject);
                    }
                    */
                    if (gameObject.tag == "Des")
                    {
                        Score();
                        Destro();
                    }
                }
            }
            //hvis holdt i venstre hånd
            if (transform.parent.gameObject.name == "LeftHand")
            {
                GameObject Lhand = GameObject.Find("LeftHand");
                if (Lhand.GetComponent<TrackVel>().v > HandV)
                {
                    Debug.Log("PARENT FOUND L");
                    /*
                    if (collision.gameObject.tag == "Des")
                    {
                        Score();
                        Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                        Destroy(collision.gameObject);

                    }
                    */
                    if (gameObject.tag == "Des")
                    {
                        Score();
                        Destro();

                    }
                }

            }
            //---------------------------------------------------------
            
            //hvis col er i hånden

            //hvis col er i højre hånd
            if (collision.transform.parent.gameObject.name == "RightHand")
            {

                GameObject Rhand = GameObject.Find("RightHand");
                if (Rhand.GetComponent<TrackVel>().v > HandV)
                {
                    Debug.Log("PARENT FOUND R");
                    /*
                    if (collision.gameObject.tag == "Des")
                    {
                        Score();
                        Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                        Destroy(collision.gameObject);
                    }
                    */
                    if (gameObject.tag == "Des")
                    {
                        Score();
                        Destro();
                    }
                }
            }
            //hvis col er i venstre hånd
            if (collision.transform.parent.gameObject.name == "LeftHand")
            {
                GameObject Lhand = GameObject.Find("LeftHand");
                if (Lhand.GetComponent<TrackVel>().v > HandV)
                {
                    Debug.Log("PARENT FOUND L");
                    /*
                    if (collision.gameObject.tag == "Des")
                    {
                        Score();
                        Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                        Destroy(collision.gameObject);

                    }
                    */
                    if (gameObject.tag == "Des")
                    {
                        Score();
                        Destro();

                    }
                }

            }
            //----------------------------------------------------------------

        }
        //hvis obj ikke er har noget med hånden at gøre under collision
        catch
        {
            try
            {
                ORb = collision.rigidbody;
                //Tjekker collisions velocity
                if (ORb.velocity.magnitude > ObjObjV || Rb.velocity.magnitude > ObjObjV)
                {
                    /*
                    if (collision.gameObject.tag == "Des")
                    {
                        Score();
                        Instantiate(Spawnee, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
                        Destroy(collision.gameObject);


                    }
                    */
                    if (gameObject.tag == "Des")
                    {
                        Score();
                        Destro();
                    }
                }

            }
            catch
            {
                //Tjekker egen velocity
                if (Rb.velocity.magnitude > ObjObjV)
                {
                    /*
                    if (collision.gameObject.tag == "Des")
                    {
                        Score();
                        Destroy(collision.gameObject);
                    }
                    */
                    if (gameObject.tag == "Des")
                    {
                        Score();
                        Destroy(gameObject);
                    }
                }
            }
        }
    }



    private void Score()
    {
        //Add Score
        ScoreHandler.score += GivenScore;
        Instantiate(SpawnedText, transform.position + Offset, Quaternion.identity);
        AudioManager.audioManager.playSound(0, gameObject);
    }
    private void Destro()
    {
        Instantiate(Spawnee, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Destroy(gameObject);
    }
}
