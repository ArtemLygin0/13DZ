/*
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public TextMeshProUGUI LoadingPercentage;
    public Image LoadingProgressBar;

    private static SceneTransition instance;
    private static bool _shouldPlayOpeningAnimation = false;

    private Animator _componentAnimator;
    private AsyncOperation _loadingSceneOperation;

    public static void SwitchToScene(string sceneName)
    {
        instance._componentAnimator.SetTrigger(name: "SceneClosing");

        instance._loadingSceneOperation = SceneManager.LoadSceneAsync(sceneName);
        instance._loadingSceneOperation.allowSceneActivation = false;
    }

    void Start()
    {
        instance = this;

        _componentAnimator = GetComponent<Animator>();

        if (_shouldPlayOpeningAnimation) _componentAnimator.SetTrigger(name: "SceneOpening");
    }

    void Update()
    {
        LoadingPercentage.text = Mathf.RoundToInt(f: _loadingSceneOperation.progress * 100) + "%";
        //_loadingSceneOperation.fillAmount = _loadingSceneOperation.progress;
    }

    public void OnAnimationOver()
    {
        _shouldPlayOpeningAnimation = true;
        _loadingSceneOperation.allowSceneActivation = true;
    }

}
*/