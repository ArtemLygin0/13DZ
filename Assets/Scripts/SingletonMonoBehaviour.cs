using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour
                        where T : SingletonMonoBehaviour<T>
{
    private static T _instance;
    //Singleton pattern
    public static T Instance => _instance;

    public void Awake()
    {
        if (_instance != null)
        {
            Destroy(_instance.gameObject);
            return;
        }
        _instance = (T)this;
    }
}