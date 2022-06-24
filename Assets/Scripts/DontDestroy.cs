using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("UI");

        if (objs.Length > 3)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}
