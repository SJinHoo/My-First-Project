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
    }

    
    void Update()
    {
        SoundSfx(shellExplosion);
    }
    public void SoundSfx(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
