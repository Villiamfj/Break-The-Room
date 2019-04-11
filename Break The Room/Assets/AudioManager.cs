using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] sounds;
    public static AudioManager audioManager;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioManager = GetComponent<AudioManager>();
        audioSource = GetComponent<AudioSource>();
    }

    public void playSound(int clip, GameObject Obj)
    {
        audioSource.PlayOneShot(sounds[clip]);
        transform.position = Obj.transform.position;
    }
}
