using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SvetL : MonoBehaviour
{
    [SerializeField] public GameObject light2;
    [SerializeField] public GameObject light3;
    [SerializeField] public GameObject light4;
    [SerializeField] public bool isLight;

    void Start()
    {
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);
    }

    public void SvetChang()
    {
        light2.SetActive(isLight);
        light3.SetActive(isLight);
        light4.SetActive(isLight);
        isLight = !isLight;
    }
}
