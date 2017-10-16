using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door

    public AudioClip keyAudio;
    public GameObject objectToCreate;

    private AudioSource keyAudioSource = null;
    
	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
        keyAudioSource = gameObject.GetComponent<AudioSource>();   
        Object.Instantiate(objectToCreate, gameObject.transform.position , Quaternion.identity);
        keyAudioSource.clip = keyAudio;
        keyAudioSource.Play();
        StartCoroutine(Wait());
    }

    IEnumerator Wait () {
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);
    }

}
