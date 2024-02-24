using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reindeer : animal
{
    public GameObject theReindeerObject;

    public reindeer()
    {
        produce = "christmas magic";
        theAnimal = theReindeerObject;
    }
}
