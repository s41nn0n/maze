using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene() 
	{
        // Reset the scene when the user clicks the sign post
		hardRestartGame();
	}

	// place this at the top of your file
	// then call this to restart game
	//http://answers.unity3d.com/questions/46918/reload-scene-when-dead.html
	void hardRestartGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}