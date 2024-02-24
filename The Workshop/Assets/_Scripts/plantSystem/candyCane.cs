using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyCane : plant
{
    public candyCane()
    {
        numberOfDatesTillMaturity = 5;
        currentMaturity = 0;
        inTheGround = false;
    }
}
