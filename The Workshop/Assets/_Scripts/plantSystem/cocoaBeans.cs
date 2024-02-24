using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cocoaBeans : plant
{
    public GameObject theCocoaBeansObject;
    public cocoaBeans()
    {
        numberOfDatesTillMaturity = 7;
        currentMaturity = 0;
        inTheGround = false;
        thePlant = theCocoaBeansObject;
    }
}
