# Project Log
Class: CS383 Soft. Eng.

Assignment: #1 Pong

## Time Log

| Date | Time In | Time Out | Total | Comments |
| :---:| :-----: | :------: | :---: | :------: |   
| 01/14/2021 | 6pm | 8pm | 2hrs | Outlined and hooked up main menu, chose font design and color scheme, researched singletons | 
| 01/15		 | 12pm| 2pm | 2hrs | Implemented Singleton gamemanagers, setup menus for and court for main game scene			  |
| 01/15		 | 2:45pm | 6pm | 3.25 hrs | Implemented player movement, ball movement, Scene loading and management, and enemy AI |
| 01/15		 | 8:30pm | 9pm | 0.5 hrs | Fixed paddle bug, added control reference to pause menu, play tested and balanced |

## Learning

1. Singletons

		Class MyClass : Monobehavior 
		{
			// reference to this class is static so that it always exists
			public static MyClass Instance { get; private set; } // use this to get a reference to this class from anywhere with MyClass.Instance

			private void Awake()
			{
				// check if reference already exists
				if(Instance != null)
				{
					Destroy(this.gameObject);
				}

				Instance = this; // if reference is not filled... reference itself
			}
		}

	This means that MyClass can be referenced from anywhere in a game with

		MyClass.Instance

2. Quitting the Application

		Application.Quit(); // Closes the application completely

3. SceneManager

		using UnityEngine.SceneManagment;
		SceneManager.LoadScene("scene_path_or_name"); // Load the specified scene see also SceneManager.LoadSceneAsync()

4. Pause Game/Time

		Time.timeScale = 0f; // Pause certain functions that get called every frame

5. Getting TextMeshProUGUI

		this.gameObject.GetComponent<TextMeshProUGUI>() // pretty unintuitive typing

6. 2D Collisions

		private void OnCollisionEnter2D(Collision2D other){} // Colliders with non-Kinematic Rigidbodies attached

		private void OnTriggerEnter2D(Collider2D other){} 	// set a collider without rigidbody as trigger
	
7. Helpful Notes

	* For the ball to properly bounce off surfaces at an angle, it needs to be able to rotate
	* Fix pong horizontal velocity so that ball doesn't get stuck in middle moving horizontally
	* AI should can be simply implemented by limiting the AI's movement speed so that it can't recover on some shots



