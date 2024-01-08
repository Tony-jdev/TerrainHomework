using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering.Universal;
using UnityEngine;

public class PlayerInteractable : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text _coinsNumber;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int coinsInt = Convert.ToInt32(_coinsNumber.text.Replace("Coins: ", "")) + 1;
            _coinsNumber.text = "Coins: " + coinsInt;
            Destroy(gameObject);
        }
    }
}
