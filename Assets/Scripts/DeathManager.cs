using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public int deaths = 0;
    public AudioClip levelCompleteSFX;
    public AudioSource audioSource;
    public GameObject musicObject;
    void Start()
    {
        GameObject sounds = GameObject.Find("Music(Clone)");
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
        if(sounds==null)
        {
            Instantiate(musicObject,new Vector3(0,0,0),Quaternion.identity);
            DontDestroyOnLoad(GameObject.Find("Music(Clone)"));
        }
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
