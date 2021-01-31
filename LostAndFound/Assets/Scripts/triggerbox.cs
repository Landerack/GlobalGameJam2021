using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerbox : MonoBehaviour
{
    public ParticleSystem darkParticle;//stop dark particles
    public AudioSource voice;
    public AudioSource music;
    public AudioClip vocal;
    public AudioClip song;

    public AudioClip regularMusic;

    private float vocalplayed = 0f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //pause dark particles
        darkParticle.Pause();
        //spawn particle gameobject on location.
        music.clip = song;
        music.Play();
        
    }

    private void Update()
    {
        timer += 1 * Time.deltaTime;
        if((vocalplayed < 1) && (timer > 2f))
        {
            voice.clip = vocal;
            voice.Play();
            vocalplayed += 1f;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        //particle stop
        darkParticle.Play();
        music.clip = regularMusic;
        music.Play();
    }
}
