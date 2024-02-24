using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cow : animal
{
    public GameObject theCowObject;

    public cow()
    {
        produce = "milk";
        theAnimal = theCowObject;
    }
}
