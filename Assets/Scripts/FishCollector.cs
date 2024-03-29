using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FishCollector : MonoBehaviour
{
	[SerializeField] GameObject prefabFish;

	GameObject fish;

	List<GameObject> fishList = new List<GameObject>();
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//(0) Left Click
		if (Input.GetMouseButtonDown(0))
		{
			SpawnFish();
		}
	}

	void SpawnFish()
	{
		//get mouseInput position
		Vector3 mousePosition = Input.mousePosition;
		mousePosition.z = -Camera.main.transform.position.z;
		//world space is the position of an object in the overall space of unity
		Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
		//create a new fish
		fish = Instantiate<GameObject>(prefabFish);
		//assign worldPosition to fish
		fish.transform.position = worldPosition;
		//add fish to the list 
		AddFish(fish);
		Debug.Log("Fish position: " + fish.transform.position);
	}

	//current fish in the list
	public List<GameObject> FishList()
	{
		return fishList;
	}

	public void AddFish(GameObject fish)
	{
		fishList.Add(fish);
		Debug.Log("fish added");

	}
	public void RemoveFish(GameObject fish)
	{
		fishList.Remove(fish);
		Debug.Log("Fish removed from the list.");
	}
}