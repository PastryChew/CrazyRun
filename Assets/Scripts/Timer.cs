using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textTimer;
    [SerializeField] private float _time;
    [SerializeField] private GameObject _loseImage;
    [SerializeField] private GameObject _winImage;
    private float _timeLeft = 0f;
    private bool _timerOn = false;

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (_timerOn)
            {
                if (_timeLeft > 0)
                {
                        _timeLeft -= Time.deltaTime;
                        _textTimer.text = Math.Round(_timeLeft, 1).ToString();
                }
                else
                {
                    _timeLeft = _time;
                    _timerOn = false;
                    if (_winImage.activeSelf == false)
                    {
                        _loseImage.SetActive(true);
                    }
                }
            }
        }
    }

    public void StartTimer()
    {
        _timeLeft = _time;
        _timerOn = true;
    }
}
    

    

