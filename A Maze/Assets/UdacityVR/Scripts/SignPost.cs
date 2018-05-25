using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// TODO: Get convenient access the Scene and SceneManager classes
// Use the 'using' keyword to include the SceneManagement namespace

public class SignPost : MonoBehaviour {

	public void ResetScene () {
		/// Called when the 'SignPost' game object is clicked
		/// - Reloads the scene

		// Prints to the console when the method is called
		Debug.Log ("'SignPost.ResetScene()' was called");
		// Use 'leftDoor' to get the start rotation of the 'Left_Door' game object and assign it to 'leftDoorStartRotation'

		// TODO: Reset the scene by getting a reference to the scene and reloading it
		// Declare a Scene named 'scene', then use SceneManager.GetActiveScene () to get the current scene and assign it to 'scene'
		// Use SceneManager.LoadScene() and the Scene.name property to reload the scene
	}
}
