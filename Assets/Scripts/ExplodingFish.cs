using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingFish : AnimatedFish
{
	private Animator explosion;

	private float explodingSeconds = 2f;


	private void Start()
	{
		explosion = GetComponent<Animator>();
		explosion.enabled = false;

	}
	public override void DestroyFish()
	{
		explosion.enabled = true;

		score += 2;
		Destroy(gameObject, explodingSeconds);
		Debug.Log("Exploding Fish destroyed.");

	}

	public override int FishScore()
	{
		return score;
	}
}
