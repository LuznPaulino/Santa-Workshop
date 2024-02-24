using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal
{
    public string produce;
    public GameObject theAnimal;

    public animal()
    {
        produce = "";
        theAnimal = null;
    }

    public animal(string theProduce, GameObject theAnimals)
    {
        produce = theProduce;
        theAnimal = theAnimals;
    }


}
