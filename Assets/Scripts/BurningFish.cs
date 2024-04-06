using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningFish : AnimatedFish
{
	private Animator fire;

	float burningSeconds = 2f;

	void Start()
	{
		// Get reference to the Animator component
		fire = GetComponent<Animator>();
		fire.enabled = false;
	}

	public override void DestroyFish()
	{
		fire.enabled = true;
		score += 3;
		Destroy(gameObject, burningSeconds);
		Debug.Log("Animated Fish destroyed.");
	}


	public override int FishScore()
	{
		return score;
	}
}
