using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reindeer : animal
{
    public GameObject theReindeerObject;

    public reindeer()
    {
        produce = "";
        theAnimal = theReindeerObject;
        maturityDays = 7;
        currentMaturityDays = 0;
    }
}
