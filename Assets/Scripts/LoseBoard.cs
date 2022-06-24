using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBoard : MonoBehaviour
{
    [SerializeField] private GameObject _loseImage;
    [SerializeField] private GameObject _overlay;
    private void Start()
    {
        _loseImage = GameObject.Find("Lose");
        _overlay = GameObject.Find("Overlay");
        _loseImage.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathBoard"))
        {
            _loseImage.SetActive(true);
            _overlay.SetActive(false);
        }
    }
}
