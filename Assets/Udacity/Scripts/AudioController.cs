using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public AudioSource presentationAudio;
    public AudioClip mainAudioClip;
    public bool isPlaying;

    public void onDoorClicked()
    {
        if (isPlaying == false)
        {

            presentationAudio.PlayOneShot(mainAudioClip);

        }

        else
        {
            isPlaying = true;
        }
    }

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
