using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant
{
    public int numberOfDatesTillMaturity;
    public int currentMaturity;
    public bool inTheGround;
    public int theYield;
    public int amountOfLightDays;
    public int amountOfWaterDays;
    public float totalFertilityOfGround;
    public float totalTemperature;
    public string tag;


    public plant()
    {
        numberOfDatesTillMaturity = 0;
        currentMaturity = 0;
        inTheGround = false;
        theYield = 0;
        tag = "Seed";
    }

    public plant(int tillMaturity, int current, bool ground, int theOutput, string theTag)
    {
        numberOfDatesTillMaturity = tillMaturity;
        currentMaturity = current;
        inTheGround = ground;
        theYield = theOutput;
        tag = theTag;
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
            tag = "seed";
        }
        if(inTheGround && currentMaturity < numberOfDatesTillMaturity)
        {
            tag = "Growing";
        }
        if (currentMaturity >= numberOfDatesTillMaturity && inTheGround)
        {
            tag = "Adult";
            yieldCalculation();
        }
    }

    public void yieldCalculation()
    {
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
