using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXplaying : MonoBehaviour
{
    public AudioSource button;
    public AudioSource jump;
    public AudioSource hit;
    public void PlayButton() {
        button.Play();
    }
    public void PlayJump() {
        jump.Play();
    }
    public void PlayHit() {
        hit.Play();
    }
}
