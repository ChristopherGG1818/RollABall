using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnHit : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
         Debug.Log("Hit something!");
        if (collision.gameObject.CompareTag("Player"))
        {
             Debug.Log("Hit Player!");
            audioSource.Play();
        }
    }
}