using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonAtScene<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance => _PrivateGetInstance();

    private static T _PrivateGetInstance()
    {
        if (instance == null)
        {
            T[] components = FindObjectsOfType<T>();
            if (components.Length == 0)
            {
                Debug.LogError($"Cannot find any component with type {typeof(T).Name} in this scene");
            }
            else if (components.Length > 1)
            {
                Debug.LogError($"Find more one component of '{typeof(T).Name}' in this scene");
            }


            instance = components[0];
        }

        return instance;
    }
}