using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public bool currentlyBurning;
    public bool burnedOut;
    public int amountInStack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void woodStatus()
    {
        if (burnedOut && amountInStack<=1)
        {
            Destroy(this.gameObject);
        }
        if (burnedOut && amountInStack >=1)
        {
            amountInStack--;
        }
    }

}
