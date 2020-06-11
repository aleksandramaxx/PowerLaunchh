using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer audioM;
    public void SetVolume(float volume)
    {
        audioM.SetFloat("Volume", volume);
    }
    public void SetFullScreen(bool issFull)
    {
        Screen.fullScreen = issFull;
    }
}
