using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{

    public AudioSource CoinSound;

    public void playSound()
    {
        CoinSound.Play();
    }

}
