using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed;
    private Vector2 vect;
    private Vector2 myPosition;
    private float multiplier = 0;
    private bool click = true;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        myPosition = transform.position;
        if (Input.GetMouseButtonDown(0)) //Right click
        {
            vect = Camera.main.ScreenToWorldPoint(Input.mousePosition);//Gets position of click
        }
        if (Input.GetMouseButtonUp(0) && click) //Release right click
        {
            GetComponent<Rigidbody2D>().AddForce((vect- myPosition).normalized * speed * multiplier);//Adds force
            click = false;
        }
        if (Input.GetMouseButton(0)) //During right click
        {
            multiplier += 2*(Time.deltaTime); //Adds multiplier
        }
        
    }
}

