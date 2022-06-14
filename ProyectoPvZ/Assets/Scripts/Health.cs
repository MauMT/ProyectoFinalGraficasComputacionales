using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public AudioSource audioSource;

    void Start()
    {
        audioSource.Play();
    }
}
