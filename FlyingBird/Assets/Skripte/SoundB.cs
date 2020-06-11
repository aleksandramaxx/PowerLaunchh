using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundB : MonoBehaviour
{
    public AudioSource m;
    public AudioClip hover;
    public AudioClip click;

    public void HoverSound()
    {
        m.PlayOneShot(hover);
    }
    public void ClickSound()
    {
        m.PlayOneShot(click);
    }
}
