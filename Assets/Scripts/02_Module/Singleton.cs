using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

// Monobehaviour 惑加 O 教臂沛
public abstract class Singleton_Mono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
                instance = (T)FindObjectOfType(typeof(T));

            return instance;
        }
    }
    private void Awake()
    {
        InitializeManager();
    }

    protected abstract void InitializeManager();
}

// Monobehaviour 惑加 X 教臂沛
public abstract class Singleton<T> where T : class, new()
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if(instance == null)
                instance = new T();

            return instance;
        }
    }

    public virtual void Initialize() { }
}
