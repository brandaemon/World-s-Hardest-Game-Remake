using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DeathUI : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public GameManager manager;
    void Start()
    {
        
    }
    void Update()
    {
        textMesh.text = "DEATHS: "+manager.deaths;
    }
}