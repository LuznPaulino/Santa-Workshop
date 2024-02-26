using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheat : plant
{
    public GameObject theWheatObject;
    public wheat()
    {
        numberOfDatesTillMaturity = 4;
        currentMaturity = 0;
        inTheGround = false;
        thePlant = theWheatObject;
    }
}
