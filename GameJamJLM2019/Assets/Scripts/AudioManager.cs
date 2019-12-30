using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip SFX_EnemySlain;
    public AudioSource SFX_Source_EnemySlain;

    public AudioClip SFX_GameOver;
    public AudioSource SFX_Source_GameOver;

    public AudioClip SFX_Movement;
    public AudioSource SFX_Source_Movement;

    void Start()
    {
        SFX_Source_EnemySlain.clip = SFX_EnemySlain;
        SFX_Source_GameOver.clip = SFX_GameOver;
        SFX_Source_Movement.clip = SFX_Movement;
    }

    public void PlayEnemySlain()
    {
        SFX_Source_EnemySlain.Play();
    }
    public void PlayGameOver()
    {
        SFX_Source_GameOver.Play();
    }
    public void PlayMovement()
    {
        SFX_Source_Movement.Play();
    }
}
