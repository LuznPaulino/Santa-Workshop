using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayAndNight : MonoBehaviour
{
    float seconds = 0;
    int minutes = 0;
    int day = 0;
    bool dayTime = true;
    bool nightTime = false;


    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60)
        {
            seconds = 0;
            minutes += 1;
            if(minutes >= 30)
            {

            }
        }

    }
}
