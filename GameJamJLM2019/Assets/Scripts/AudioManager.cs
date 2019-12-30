using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource SFX_Source;

    public AudioClip[] SFX_Array;

    public static AudioManager Instance { get; private set; }
    public enum SFXClips{SFX_EnemySlain, SFX_GameOver, SFX_Movement};
    protected void Awake()
    {
        Instance = this;
    }

    public void PlaySingle(string clip)
    {
        SFXClips SFX = (SFXClips)Enum.Parse(typeof(SFXClips), clip.ToString());
        SFX_Source.clip = SFX_Array[(int)SFX];
        SFX_Source.Play();
    }
}
