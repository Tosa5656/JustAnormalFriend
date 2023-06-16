using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svet : MonoBehaviour
{
    [SerializeField] public GameObject light1;
    [SerializeField] public bool isLight;

    void Start()
    {
        light1.SetActive(false); 
    }

    public void SvetChange()
    {
        light1.SetActive(isLight);
        isLight = !isLight;
    }
}
