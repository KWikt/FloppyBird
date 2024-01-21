using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEfectPlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip buttonClick;
    public AudioClip GameOver;
    public AudioClip flyight;
    public AudioSource source2;

    public void ClickSound()
    {
        source.clip = buttonClick;
        source.Play();
    }

    public void GameOverSound()
    {
        source2.clip = GameOver;
        source2.Play();
    }

    public void FlyightSound()
    {
        source.clip = flyight;
        source.Play();
    }
}
