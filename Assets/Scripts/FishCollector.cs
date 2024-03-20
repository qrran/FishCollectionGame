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
		
		//I'm putting(0) Left Click here because my mac mouse doesn't react to right click after tested several times
		if (Input.GetMouseButtonDown(0))
		{
			// calculate world position of mouse click
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = -Camera.main.transform.position.z;
			Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
			//create a new fish
			fish = Instantiate<GameObject>(prefabFish);
			Debug.Log("fish instantiated.");
			//get the positoin of fish
			fish.transform.position = worldPosition;
			fishList.Add(fish);
			Debug.Log("fish added");
		}
	}

}

