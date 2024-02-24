using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheep : animal
{
    public GameObject theSheepObject;

    public sheep()
    {
        produce = "wool";
        theAnimal = theSheepObject;
        maturityDays = 5;
        currentMaturityDays = 0;
    }
}
