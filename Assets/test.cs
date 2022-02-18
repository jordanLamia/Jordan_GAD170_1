using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    //variables up top 
    /*
     multi line power!
    */
    public int fuel = 100;
    public int laps;
    public float lapProgress;
    public float reqlapprogress = 200f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check how much fuel we have
        //if we still have more than zero fuel, let's go!
        if (fuel > 0)

        {    // we have fuel 
            //increase our progress and decrease our fuel
            lapProgress += 5;//increase by 1
            fuel--;
        }
        else
        {
            //we don't have fuel 
            Debug.Log("we've run out of fuel");
        }


        //is our current progress, equal to or higher than the required progress 
        if (lapProgress >= reqlapprogress)
        {

            laps++; //increase laps 1
            lapProgress = 0; //reset our lap progress 
        }

        //if it is, increase our lap count and reset our current progress 


    }
}
