using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

	public AudioClip coinAudio;
	private AudioSource coinAudioSource = null;

	public GameObject objectToCreate;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		coinAudioSource = gameObject.GetComponent<AudioSource>();	

    	Object.Instantiate(objectToCreate, gameObject.transform.position , Quaternion.identity);
		coinAudioSource.clip = coinAudio;
    	coinAudioSource.Play();
		StartCoroutine(Wait());

    }

    IEnumerator Wait () {
        yield return new WaitForSeconds(1.2f);
        Destroy(gameObject);
	}

}
