using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
	private bool locked = true;
	private bool opening = false;

	public AudioClip openDoorAudio;
	public AudioClip lockedAudio;
	private AudioSource doorLockedSound = null;

	public GameObject objectToCreate;

	public AudioClip clip_click					= null;	

    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
		var transform = gameObject.GetComponent<Transform>();
    	if (getDoorState()) {
    		if (transform.localPosition.y < 8) {
				transform.localPosition += new Vector3(0, 0.1F, 0);
    		}
    	}

    }

    public void OnDoorClicked() {
		doorLockedSound = gameObject.GetComponent<AudioSource>();	
    	
    	if (!locked) {
    			opening = !opening;
    			doorLockedSound.clip = openDoorAudio;
    			doorLockedSound.Play();
    		} else {
    			// doorLockedSound.clip = soundFiles[0];
    			doorLockedSound.clip = lockedAudio;
    			doorLockedSound.Play();
    		}

        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here

        locked = !locked;
    }

    public bool getDoorState() {
    	return !locked && opening;
    }


    IEnumerator Wait () {
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }


}
