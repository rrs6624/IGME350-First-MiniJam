using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public List<GameObject> spawnObjects;
    public int numberOfItems;
    void Start()
    {
        //3 of each item will spawn
        numberOfItems = spawnObjects.Count * 3;
        int currentItem = 0;
        for (int i = 0; i < numberOfItems; i++) { 
            if (numberOfItems % 3 == 0)
            {
                currentItem++;
            }
            Vector3 itemPosition = transform.position;
            itemPosition.x += Random.Range(-10, 10);
            itemPosition.y += Random.Range(-10, 10);
            Instantiate(spawnObjects[currentItem], itemPosition, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
