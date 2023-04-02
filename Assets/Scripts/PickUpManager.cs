using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : SingletonMonoBehaviour<PickUpManager>
{
    [SerializeField] private int _currentPlayerAmount;
    [SerializeField] private AnimatedScoreDisplay _scoreDisplay;

    private void Start()
    {
        _scoreDisplay.Set(_currentPlayerAmount);
    }

    public void AddMoney(int amount)
    {
        _scoreDisplay.Animate(_currentPlayerAmount, _currentPlayerAmount + amount);

        _currentPlayerAmount += amount;
    }
}
