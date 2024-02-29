using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treePlace : MonoBehaviour
{
    public int amountOfDaysWithOutTree;
    public bool treePlanted;
    public GameObject theTreeObject;
    public GameObject theWoodObject;
    // Start is called before the first frame update



    public treePlace()
    {
        amountOfDaysWithOutTree = 0;
        treePlanted = false;
    }

    public void plantTheTree()
    {
        Instantiate(theTreeObject, this.GetComponent<Transform>().position, this.GetComponent<Transform>().rotation);
        treePlanted = true;
    }

    public void updateAmountOfDaysWithOutTree()
    {
        if (!treePlanted)
        {
            amountOfDaysWithOutTree++;
        }
    }

    public void treeCuttedDown()
    {
        Destroy(theTreeObject);
        treePlanted = false;
        int amountOfWoodCreated = Random.Range(1, 5);
        
        for(int i = 0; i< amountOfWoodCreated; i++)
        {
            Instantiate(theWoodObject, this.GetComponent<Transform>().position, this.GetComponent<Transform>().rotation);
        }
    }



}
