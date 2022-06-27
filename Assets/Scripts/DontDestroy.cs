using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("UI");

        if(objs.Length>1)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
