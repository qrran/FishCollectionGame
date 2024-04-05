using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fish : MonoBehaviour
{
    protected static int score = 0;
    public GameObject fish;

    protected HUD hud;

	private void Start()
	{
		hud = GameObject.FindGameObjectWithTag("HUD").GetComponent<HUD>();
	}

	public abstract void DestroyFish();

    public abstract int FishScore();
}
