using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public int deaths = 0;
    void Start()
    {
        GameObject sounds = GameObject.Find("SFX/Music");
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(sounds);
    }
    public void addDeath()
    {
        deaths++;
    }
    void Update()
    {
        
    }
}
