using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : SingletonMonoBehaviour<GameStateManager>
{
    private bool _isDead = false;
    private GameObject _player;

    private void Start()
    {
        _player = FindObjectOfType<PlayerInputBase>().gameObject;
    }

    public void Die()
    {
        Destroy(_player.gameObject);
        _isDead = true;
    }
}