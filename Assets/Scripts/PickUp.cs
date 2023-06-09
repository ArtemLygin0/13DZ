using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private int _bonusAmount = 200;
    [SerializeField] private string _playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_playerTag))
        {
            Pick();
        }
    }

    private void Pick()
    {
        PickUpManager.Instance.AddMoney(_bonusAmount);
        CoinAnimationManager.Instance.Animate(_bonusAmount, transform.position);
        Destroy(gameObject);
    }
}
