using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingFish : AnimatedFish
{
	public override void DestroyFish()
	{
		Destroy(prefabAnimation);
		Debug.Log("Exploding Fish destroyed.");
		score += 2;
	}

	public override int FishScore()
	{
		return score;
	}
}
