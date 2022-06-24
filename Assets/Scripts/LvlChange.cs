using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlChange : MonoBehaviour
{
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ReastartLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
