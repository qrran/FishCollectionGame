using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularFish : Fish
{
	public override void DestroyFish()
	{
		Destroy(gameObject);
		Debug.Log("Regular Fish destroyed.");
		score += 1;

	}
	public override int FishScore()
	{
		return score;
	}
}
