using UnityEngine;
using System.Collections;

public class lineScript : MonoBehaviour {


	private float multiplier = 0;
	public Renderer _rend;
	private float a = 0.2f;



	// Use this for initialization
	void Start () {
		_rend = GetComponent<Renderer>();
		_rend.enabled = false;
		SpriteRenderer renderer = GetComponent<SpriteRenderer>();
		renderer.color = new Color(a, 0f, 0f, 1f);

	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton(0)) //During right click
		{

			_rend.enabled = true;
			multiplier += 2*(Time.deltaTime); //Adds multiplier

			if (multiplier > 2) 
			{
				SpriteRenderer renderer = GetComponent<SpriteRenderer>();
				renderer.color = new Color(0.3f, 0f, 0f, 1f);
			}
			if (multiplier > 4) 
			{
				SpriteRenderer renderer = GetComponent<SpriteRenderer>();
				renderer.color = new Color(0.4f, 0f, 0f, 1f);
			}
			if (multiplier > 6) 
			{
				SpriteRenderer renderer = GetComponent<SpriteRenderer>();
				renderer.color = new Color(0.5f, 0f, 0f, 1f);
			}
			if (multiplier > 8) 
			{
				SpriteRenderer renderer = GetComponent<SpriteRenderer>();
				renderer.color = new Color(0.6f, 0f, 0f, 1f);
			}
			if (multiplier > 10) 
			{
				SpriteRenderer renderer = GetComponent<SpriteRenderer>();
				renderer.color = new Color(0.7f, 0f, 0f, 1f);
			}
			if (multiplier > 12) 
			{
				SpriteRenderer renderer = GetComponent<SpriteRenderer>();
				renderer.color = new Color(0.8f, 0f, 0f, 1f);
			}
			if (multiplier > 14) 
			{
				SpriteRenderer renderer = GetComponent<SpriteRenderer>();
				renderer.color = new Color(0.9f, 0f, 0f, 1f);
			}
			if (multiplier > 16) 
			{
				SpriteRenderer renderer = GetComponent<SpriteRenderer>();
				renderer.color = new Color(1f, 0f, 0f, 1f);
			}


		}

		if (Input.GetMouseButtonUp(0)) //Release right click		
		{
			_rend.enabled = false;
			
			
		}
	
	}
}
