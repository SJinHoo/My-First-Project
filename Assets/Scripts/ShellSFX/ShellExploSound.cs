using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExploSound : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip shellExplosion;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SoundSfx(shellExplosion);
        Destroy(gameObject, 3f);
    }

    
    void Update()
    {
    }
    public void SoundSfx(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
