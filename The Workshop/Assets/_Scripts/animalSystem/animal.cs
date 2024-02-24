using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal
{
    public string produce;
    public GameObject theAnimal;
    public int maturityDays;
    public int currentMaturityDays;
    public int amountOfProduce;
    public bool isWarm;
    public bool hasBeenPetted;
    public bool hasBeenFeed;


    public animal()
    {
        produce = "";
        theAnimal = null;
        maturityDays = 0;
        currentMaturityDays = 0;
        isWarm = true;
        hasBeenPetted = true;
        hasBeenFeed = true;
    }

    public animal(string theProduce, GameObject theAnimals, int amountOfDays, int amountOfCurrentDays, bool warmed, bool petted, bool feed)
    {
        produce = theProduce;
        theAnimal = theAnimals;
        maturityDays = amountOfDays;
        currentMaturityDays = amountOfCurrentDays;
        isWarm = warmed;
        hasBeenPetted = petted;
        hasBeenFeed = feed;
    }

    public int returnTheAmountOfProduce()
    {
        return amountOfProduce;
    }

    public string returnThProduce()
    {
        return produce;
    }

    public void updateTheDays()
    {
        currentMaturityDays++;
    }

    public void updateTheAmountOfProduce()
    {
        if (produce == "")
        {
            amountOfProduce = 0;
        }
        
        if(isWarm && hasBeenFeed & hasBeenPetted)
        {
            amountOfProduce = Random.Range(1, 4);
        }
    }

    public void returnMaturityStatus()
    {
        if (currentMaturityDays == 0)
        {
            theAnimal.tag = "Baby";
        }
        if(currentMaturityDays>0 && currentMaturityDays< maturityDays)
        {
            theAnimal.tag = "Growing";
        }
        if(currentMaturityDays >= maturityDays)
        {
            theAnimal.tag = "Adult";
            updateTheAmountOfProduce();
            returnTheAmountOfProduce();
            returnThProduce();
        }
    }

    public void animalIsNotWarm()
    {
        isWarm = false;
    }

    public void animalIsWarm()
    {
        isWarm = true;
    }

    public void animalIsNotPetted()
    {
        hasBeenPetted = false;
    }

    public void animalIsPetted()
    {
        hasBeenPetted = true;
    }

    public void animalIsNotFeed()
    {
        hasBeenFeed = false;
    }

    public void animalIsFeed()
    {
        hasBeenFeed = true;
    }


}
