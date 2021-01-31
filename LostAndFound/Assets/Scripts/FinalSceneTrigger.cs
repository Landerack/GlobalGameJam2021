using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneTrigger : MonoBehaviour
{
    public AudioSource voice;
    public AudioClip vocal;


    private float vocalset = 0f;
    private float timer = 0f;
    private float timerlock = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (timerlock > 0f)
        {
            timer += 1 * Time.deltaTime;
        }
        if (timer > 6f)
        {
            NextScene();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            voice.clip = vocal;
            timerlock = 1f;
            voice.Play();
        }
    }

    private void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
