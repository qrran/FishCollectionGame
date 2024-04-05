using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class BurningFish : AnimatedFish
{
	[SerializeField] GameObject prefabBurningFish;

	float Burningseconds;

	Timer burningTimer;

	public override void DestroyFish()
	{
		Destroy(prefabAnimation);
		Debug.Log("Animated Fish destroyed.");
		score += 3;

	}

	public override int FishScore()
	{
		return score;
	}
}
