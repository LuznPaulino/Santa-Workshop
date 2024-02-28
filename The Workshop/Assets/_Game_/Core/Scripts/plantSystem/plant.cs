using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant
{
    public int numberOfDatesTillMaturity;
    public int currentMaturity;
    public bool inTheGround;
    // boolean for groundWatered
    // boolean for buildingHeat 
    public int theYield;
    public int amountOfLightDays;
    public int amountOfWaterDays;
    public float totalFertilityOfGround;
    public float totalTemperature;
    public GameObject thePlant;


    public plant()
    {
        numberOfDatesTillMaturity = 0;
        currentMaturity = 0;
        inTheGround = false;
        theYield = 0;
        thePlant = null;
    }

    public plant(int tillMaturity, int current, bool ground, int theOutput, string theTag, GameObject thePlantType)
    {
        numberOfDatesTillMaturity = tillMaturity;
        currentMaturity = current;
        inTheGround = ground;
        theYield = theOutput;
        thePlant = thePlantType;
    }

    public void increaseTheCurrentMaturity()
    {
        currentMaturity++;
    }

    public void inGround()
    {
        inTheGround = true;
    }

    public void currentStatus()
    {
        if (!inTheGround)
        {
            thePlant.tag = "Seed";
        }
        if(inTheGround && currentMaturity < numberOfDatesTillMaturity)
        {
            thePlant.tag = "Growing";
        }
        if (currentMaturity >= numberOfDatesTillMaturity && inTheGround)
        {
            thePlant.tag = "Adult";
            yieldCalculation();
        }
    }

    public void yieldCalculation()
    {
        ///for the total temperature, add a boolean called heat. If the boolean is true then total tempeature would += 1 for each day. 
        theYield = Mathf.RoundToInt(((amountOfLightDays / numberOfDatesTillMaturity) + (amountOfWaterDays / numberOfDatesTillMaturity)+ ((totalFertilityOfGround / numberOfDatesTillMaturity)/100) + ((totalTemperature / numberOfDatesTillMaturity) / 100)) * numberOfDatesTillMaturity);
    }

    public void addToFertileGround(int currentGroundFertility)
    {
        totalFertilityOfGround += currentGroundFertility;
    }

    public void addToTemperature(int currentGroundFertility)
    {
        totalFertilityOfGround += totalTemperature;
    }

    public void addToLightDays()
    {
        amountOfLightDays++;
    }

    public void addToWaterDays()
    {
        amountOfWaterDays++;
    }



}
