using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 100;
    public float limit = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertComponent = this.transform.position.y + (Time.deltaTime * (Input.GetAxis("Vertical") * speed));
        Vector3 vertPos = new Vector3(transform.position.x, Mathf.Clamp(vertComponent, -limit, limit), transform.position.z);
        this.transform.position = vertPos;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name != "Ball_Circle")
        {
            return;
        }

        PlayerManager.Instance.Score++;
        UIManager.Instance.UpdateScore();
    }
}
