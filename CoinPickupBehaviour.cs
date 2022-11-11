using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPickupBehaviour : MonoBehaviour
{
    public TextMeshProUGUI CoinsValueText;
    private bool taken = true;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            taken = false;
            Destroy(gameObject);
            CoinsValueText.text = (Int32.Parse(CoinsValueText.text) + 1).ToString();
        }
    }
}
