using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    //regular fish has 1 point each
    int pointValue = 1;
    GameObject fish;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int PointValue()
    {
        return pointValue;
    }

    public void destroyFish()
    {
        Destroy(gameObject);
    }
}
