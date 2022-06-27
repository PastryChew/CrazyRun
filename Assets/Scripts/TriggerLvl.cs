using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLvl : MonoBehaviour
{
    [SerializeField] private GameObject _winImage;
    [SerializeField] private GameObject _overlay;
    private bool _playerFinish;
    private bool _ballFinish;
    private void Start()
    {
        _winImage = LvlChange.instance.GetScreen(1);
        _overlay = GameObject.Find("Overlay");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().buildIndex != 3)
        {
            if (other.CompareTag("Player"))
            {
                _winImage.SetActive(true);
                _overlay.SetActive(false);
                other.gameObject.SetActive(false);
            }
        }
        else
        {
            if (other.CompareTag("Player"))
            {
                _playerFinish = true;
            }
            if (other.CompareTag("Ball"))
            {
                _ballFinish = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _playerFinish = false;
        }
        if (other.CompareTag("Ball"))
        {
            _ballFinish = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (_playerFinish && _ballFinish)
        {
            _winImage.SetActive(true);
            _overlay.SetActive(false);
            other.gameObject.SetActive(false);
        }
    }
}
