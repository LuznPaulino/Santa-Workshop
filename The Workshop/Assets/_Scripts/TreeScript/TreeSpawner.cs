using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public int currentAmountOfTrees;
    public int currentAmountOfTreeSpots;

    void Update()
    {
        if (currentAmountOfTrees < currentAmountOfTreeSpots)
        {
            GameObject[] currentTreeSpots = GameObject.FindGameObjectsWithTag("Tree Spawn Spot");
            int currentTreeSpotsSize = GameObject.FindGameObjectsWithTag("Tree Spawn Spot").Length;

            for (int i = 0; i < currentTreeSpotsSize; i++)
            {
                if(currentTreeSpots[i].GetComponent<treePlace>().amountOfDaysWithOutTree > 2)
                {
                    currentTreeSpots[i].GetComponent<treePlace>().plantTheTree();
                }
            }
        }
    }



}
