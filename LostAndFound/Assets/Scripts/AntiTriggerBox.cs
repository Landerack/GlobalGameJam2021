using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiTriggerBox : MonoBehaviour
{
    public AudioSource voice;
    public AudioSource music;
    public AudioClip vocal;
    public AudioClip song;
    public GameObject NextMemory;
    public GameObject antiScene;

    public AudioClip RegularSong;

    private float vocalplayed = 0f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        music.clip = song;
        music.Play();
        
    }

    private void Update()
    {
        timer += 1 * Time.deltaTime;
        if((vocalplayed < 1) && (timer > 1.5f))
        {
            voice.clip = vocal;
            voice.Play();
            vocalplayed += 1f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        NextMemory.gameObject.SetActive(true);
        Destroy(antiScene.gameObject);
        music.clip = RegularSong;
        music.Play();
    }
}
