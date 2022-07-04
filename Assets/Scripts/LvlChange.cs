using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlChange : MonoBehaviour
{
    [SerializeField] private GameObject _winImage;
    [SerializeField] private GameObject _loseImage;
    [SerializeField] private GameObject _overlayImage;
    [SerializeField] private GameObject _backgrImage;
    [SerializeField] private GameObject _backgrLvlImage;
    [SerializeField] private Timer _timer;
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
        SceneManager.LoadScene(_index);
        if (_index == 0)
        {
            _backgrImage.SetActive(true);
            _overlayImage.SetActive(false);
        }
        else
        {
            _timer.StartTimer();
            _backgrImage.SetActive(false);
            _overlayImage.SetActive(true);
            _backgrLvlImage.SetActive(false);
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
        _timer.StartTimer();
        _loseImage.SetActive(false);
        _overlayImage.SetActive(true);
    }
}
