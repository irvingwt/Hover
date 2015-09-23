using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed;
    private Vector2 vect;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow)){
            //GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed);
            Vector2 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * speed);
            /*Vector2 position = this.transform.position;
            position.x--;
            this.transform.position = position;*/
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
    }
}
