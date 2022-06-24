using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLvl : MonoBehaviour
{
    [SerializeField] private GameObject winImage;
    [SerializeField] private GameObject overlay;

    private void Start()
    {
        winImage = GameObject.Find("Win");
        overlay = GameObject.Find("Overlay");
        winImage.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            winImage.SetActive(true);
            overlay.SetActive(false);
            other.gameObject.SetActive(false);
        }
    }
}
