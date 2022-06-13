using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        if(PauseMenu.gameIsPaused){
            audioSource.Pause();
        }
        else{
            audioSource.UnPause();
        }    
    }
}
