using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCall : MonoBehaviour
{
    AudioSource Audios;
    public AudioClip voice;
    // Start is called before the first frame update
    void Start()
    {
        Audios = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            if (transform.parent.name == "RightHand" || transform.parent.name == "LeftHand")
            {
                Audios.clip = voice;
            }
        }catch
        {
            //Nothing
        }
    }
}
