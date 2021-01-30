using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerbox : MonoBehaviour
{
    public ParticleSystem Particles;//stop dark particles
    public GameObject particles;//Spawn Particle Gameobject
    public AudioSource voice;
    public AudioSource music;
    public AudioClip vocal;
    public AudioClip song;

    // Start is called before the first frame update
    void Start()
    {
        //pause dark particles
        //spawn particle gameobject on location.
        
    }

 
    private void OnTriggerExit(Collider other)
    {
        //particle stop
    }
}
