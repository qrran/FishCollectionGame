using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
	FishCollector fishInSceen;

	GameObject targetFish;

	Vector2 direction;

	Rigidbody2D rdbd;

	// Start is called before the first frame update
	void Start()
	{
		fishInSceen = Camera.main.GetComponent<FishCollector>();
		rdbd = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnMouseDown()
	{

	}

	void OnTriggerStay2D(Collider2D other)
	{

	}
}

