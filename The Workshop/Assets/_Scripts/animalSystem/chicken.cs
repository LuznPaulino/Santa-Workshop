using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : animal
{
    public GameObject theChickenObject;
    public chicken()
    {
        produce = "eggs";
        theAnimal = theChickenObject;
    }
}
