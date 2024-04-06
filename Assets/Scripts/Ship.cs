using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class Ship : MonoBehaviour
{
	GameObject targetFish;

	FishCollector fishCollector;

	int score;

	Vector2 direction;

	Rigidbody2D rgbd;
	//random fish?


	// Start is called before the first frame update
	void Start()
	{
		fishCollector = Camera.main.GetComponent<FishCollector>();
		rgbd = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("space"))
		{
			OnMouseDown();
		}
	}

	public int Score()
	{
		return score;
	}

	//activate the ship
	void OnMouseDown()
	{
		if (fishCollector.FishList().Count != 0)
		{
			targetFish = fishCollector.FishList()[0];
			direction = new Vector2(targetFish.transform.position.x - transform.position.x,
									targetFish.transform.position.y - transform.position.y);
			rgbd.AddForce(direction, ForceMode2D.Impulse);
		}
	}

	//destroy the fish
	void OnTriggerStay2D(Collider2D other)
	{
		if (targetFish == other.gameObject)
		{
			Fish fish = other.GetComponent<Fish>();
			if (fish != null)
			{
				fish.DestroyFish();
			}
			fishCollector.RemoveFish(targetFish);

			Debug.Log("current score: " + fish.FishScore());
			rgbd.velocity = new Vector2(0, 0);
			OnMouseDown();

		}
	}
}