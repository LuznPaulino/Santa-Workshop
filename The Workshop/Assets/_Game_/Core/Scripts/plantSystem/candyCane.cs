using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyCane : plant
{
    public GameObject theCandyCaneObject;
    public candyCane()
    {
        numberOfDatesTillMaturity = 5;
        currentMaturity = 0;
        inTheGround = false;
        thePlant = theCandyCaneObject;
    }
}
