using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCall : MonoBehaviour
{
    AudioSource Audios;
    public AudioClip voice;
    AudioClip ring;
    bool isRing = true;
    public float Score2start = 0;
    bool isOn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Audios = GetComponent<AudioSource>();
        ring = Audios.clip;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOn && ScoreHandler.score >= Score2start)
        {
            isOn = true;
            Audios.Play();
        }

        if (isOn)
        {
            try
            {
                if (transform.parent.name == "RightHand" && isRing || transform.parent.name == "LeftHand" && isRing)
                {
                    Audios.clip = voice;
                    Audios.Play();
                    isRing = false;
                }
            }
            catch
            {
                if (!isRing)
                {
                    Audios.clip = ring;
                    Audios.Play();
                    isRing = true;
                }
            }
        }
    }
}
