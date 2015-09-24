using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed;
    private Vector3 vect;
    private Vector3 myPosition;
    private float multiplier = 0;
    private bool click = true;

	// Use this for initialization
	void Start () {
        myPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0) && click) //Release right click
        {
            vect = Camera.main.ScreenToWorldPoint(Input.mousePosition);//Gets position of click
            GetComponent<Rigidbody2D>().AddForce((vect- myPosition).normalized * speed * multiplier);//Adds force
            click = false;
        }
        if (Input.GetMouseButton(0) && click) //During right click
        {
            multiplier += 2*(Time.deltaTime); //Adds multiplier
            vect = Camera.main.ScreenToWorldPoint(Input.mousePosition);//Gets position of click
            transform.rotation = Quaternion.LookRotation(Vector3.forward, vect - transform.position);
        }
        if (transform.position.x < -300 || transform.position.x > 750)
        {
            Application.LoadLevel(1);
        }
    }
}

