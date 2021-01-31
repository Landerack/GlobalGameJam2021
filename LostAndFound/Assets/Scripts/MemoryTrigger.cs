using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryTrigger : MonoBehaviour
{
    public GameObject Memory;
    private AudioSource sound;


    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            sound.Play();

            Memory.gameObject.SetActive(true);

            Destroy(this.gameObject);
        }
    }
}
