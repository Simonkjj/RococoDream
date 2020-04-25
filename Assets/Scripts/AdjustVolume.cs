using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AdjustVolume : MonoBehaviour
{
    public AudioMixer audioMixer;
   public void SetVolume (float volume)
   {
        Debug.Log("Volumechange");
        audioMixer.SetFloat("volume", volume);
   }
}
