using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnimatedScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private float _maxAnimationDuration = 2f;
    [SerializeField] private float _delayBetweenNumbers = 0.02f;

    [ContextMenu("Test")]
    public void Animate()
    {
        var startAmount = 100;
        var targetAmount = 1500;

        Animate(startAmount, targetAmount);
    }

    public void Set(int value)
    {
        _countText.text = value.ToString();
    }

    public void Animate(int from, int to)
    {
        _countText.text = from.ToString();

        StartCoroutine(AnimateCoroutine(from, to));
    }

    private IEnumerator AnimateCoroutine(int from, int to)
    {
        var range = to - from;
        var duraton = range / _delayBetweenNumbers;
        duraton = Mathf.Min(_maxAnimationDuration, duraton);
        var delay = duraton / range;

        for (int i = from; i <= to; i++)
        {
            _countText.text = i.ToString();
            yield return new WaitForSeconds(delay);
        }
    }
}
