using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public float x_velocityMax = 10f;
	public float velocityX = 0; // set the x velocity component for the duration of the game
	private Rigidbody2D ballBody;

    // Start is called before the first frame update
    void Start()
    {
        ballBody = this.transform.GetComponent<Rigidbody2D>();

        velocityX = Random.Range(4f, x_velocityMax);
        float randY = Random.Range(1, 3); // choose a random angle for the ball

        ballBody.velocity = new Vector2(velocityX, randY);
    }

    // Update is called once per frame
    void Update()
    {
    	
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

    	float direction = ballBody.velocity.x;
    	if(direction < 0) // reverse direction and update the ball speed
    	{
    		direction = -1f;
    	}else
    	{
    		direction = 1f;
    	}

    	if(other.gameObject.name == "AIPaddle_Square" || other.gameObject.name == "PlayerPaddle_Square")
    	{
    		// natural bounce
    		ballBody.velocity = new Vector2(velocityX * direction, ballBody.velocity.y);
    	}else
    	{
    		// wall bounce, clamp the y component of the velocity greater than zero
    		// so that the ball ALWAYS reaches the other side of room
    		ballBody.velocity = new Vector2(velocityX * direction, ballBody.velocity.y);
    	}
    	
    }
}
