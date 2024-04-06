using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularFish : Fish
{
	public override void DestroyFish()
	{
		score += 1;
		Destroy(gameObject);
		Debug.Log("Regular Fish destroyed.");
	}
	public override int FishScore()
	{
		return score;
	}
}
