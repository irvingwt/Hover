using UnityEngine;
using System.Collections;

public class Marscript : MonoBehaviour {


	public float velocidad = 1.5f;
	private Vector3 obj;


	// Use this for initialization
	void Start () {

		obj = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0)) {
			obj = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			obj.z = transform.position.z;
			
		}
		transform.position = Vector3.MoveTowards(transform.position, obj, velocidad * Time.deltaTime);
		
	}
	

}
