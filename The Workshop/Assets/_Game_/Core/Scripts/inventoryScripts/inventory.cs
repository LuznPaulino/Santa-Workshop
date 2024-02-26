using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public inventoryItems[,] thePlayerInventory = new inventoryItems[3, 10];
    public inventoryItems[] theHotBar = new inventoryItems[10];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theCurrentHotBar();
    }

    public void storingObjects(objectProperties theObjectToBeStored)
    {
        for (int i = 0; i < thePlayerInventory.Length; i++)
        {
            for (int j = 0; j < thePlayerInventory.GetLength(i); j++)       
            {
                if(thePlayerInventory[i,j] == null)
                {
                    inventoryItems inventorySpot = new inventoryItems();
                    inventorySpot.tag = theObjectToBeStored.tag;
                    inventorySpot.name = theObjectToBeStored.name;
                    inventorySpot.description = theObjectToBeStored.description;
                    inventorySpot.theObjectImage = theObjectToBeStored.theObjectImage;
                    inventorySpot.row = j;
                    inventorySpot.column = i;
                    thePlayerInventory[i, j] = inventorySpot;
                }
            }
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E) && other.tag == "interactableObject")
        {
            storingObjects(other.GetComponent<objectProperties>());
        }
    }

    public void theCurrentHotBar()
    {
        for (int j = 0; j < thePlayerInventory.GetLength(0); j++)
        {
            theHotBar[j] = thePlayerInventory[0, j];
        }
    }

}
