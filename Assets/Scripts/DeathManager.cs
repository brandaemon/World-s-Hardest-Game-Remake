using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public int deaths = 0;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void addDeath()
    {
        deaths++;
    }
    void Update()
    {
        
    }
}
