using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
	FishCollector fishInScene;

	GameObject targetFish;

	Vector2 direction;

	Rigidbody2D rdbd;

	BoxCollider2D collider2D;

	// Start is called before the first frame update
	void Start()
	{
		fishInScene = Camera.main.GetComponent<FishCollector>();
		rdbd = GetComponent<Rigidbody2D>();
		collider2D = GetComponent<BoxCollider2D>();

	}

	// Update is called once per frame
	void Update()
	{
		OnMouseDown();
	}

	void OnMouseDown()
	{
		if(targetFish != null)
			Destroy(targetFish);
	}

	void OnTriggerStay2D(Collider2D other)
	{
		targetFish = other.gameObject;
	}
}

