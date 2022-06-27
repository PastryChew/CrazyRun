using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBoard : MonoBehaviour
{
    [SerializeField] private GameObject _loseImage;
    [SerializeField] private GameObject _overlay;
    [SerializeField] private GameObject _winImage;
    private void Awake()
    {
        _loseImage = LvlChange.instance.GetScreen(2);
        _winImage = LvlChange.instance.GetScreen(1);
        _overlay = GameObject.Find("Overlay");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathBoard"))
        {
            if (!_winImage.activeSelf)
            {
                _loseImage.SetActive(true);
                _overlay.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}
