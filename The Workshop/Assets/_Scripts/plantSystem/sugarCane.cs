using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sugarCane : plant
{
    public GameObject theSugarCaneObject;
    public sugarCane()
    {
        numberOfDatesTillMaturity = 6;
        currentMaturity = 0;
        inTheGround = false;
        thePlant = theSugarCaneObject;
    }
}
