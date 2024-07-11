using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public int deaths = 0;
    public AudioClip levelCompleteSFX;
    public AudioSource audioSource;
    void Start()
    {
        GameObject sounds = GameObject.Find("Music");
        audioSource = GetComponent<AudioSource>;
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(sounds);
    }
    public void addDeath()
    {
        deaths++;
    }
    public void finishSFX()
    {
        audioSource.PlayOneShot(levelCompleteSFX, 1F);
    }
}
