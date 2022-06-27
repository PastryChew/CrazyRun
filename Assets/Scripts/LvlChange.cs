using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlChange : MonoBehaviour
{
    [SerializeField] private GameObject _winImage;
    [SerializeField] private GameObject _loseImage;
    public static LvlChange instance;
    private void Awake()
    {
        if (!instance)
            instance = this;
    }
    public GameObject GetScreen(int index)
    {
        if (index == 1)
        {
            return _winImage;
        }
        else
        {
            return _loseImage;
        }
    }
    public void LoadLevel(int _index)
    {
        if (SceneManager.GetActiveScene().buildIndex == _index)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else 
        {
            SceneManager.LoadScene(_index);
        }
    }

    public void NextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex != 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
    public void ReastartLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
