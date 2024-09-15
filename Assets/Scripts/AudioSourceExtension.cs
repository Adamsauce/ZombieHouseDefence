﻿using UnityEngine;

    public static class AudioSourceExtensions
    {
        public static void PlaySound(this AudioSource audioSource, AudioClip clip)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }