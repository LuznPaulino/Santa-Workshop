using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peppermint : plant
{
    public GameObject thePeppermintObject;
    public peppermint()
    {
        numberOfDatesTillMaturity = 8;
        currentMaturity = 0;
        inTheGround = false;
        thePlant = thePeppermintObject;
    }
}
