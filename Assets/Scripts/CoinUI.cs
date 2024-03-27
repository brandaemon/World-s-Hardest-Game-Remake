using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public GameManager manager;
    void Start()
    {
        
    }
    void Update()
    {
        textMesh.text ="COINS: "+manager.collectedCoins+"/"+manager.totalCoins;
    }
}