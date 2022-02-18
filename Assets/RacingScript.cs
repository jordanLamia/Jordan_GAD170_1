using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{
    int laps = 0;

    float curLapProgress = 0f;
    float reqLapProgress = 100f;

    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GainProgress(speed);
        }
    }

    public void GainProgress(float progress)
    {
        curLapProgress += progress;
        Debug.Log("Gained " + progress + " progress");
        Debug.Log("Total current progress is now: " + curLapProgress);
        CheckProgress(curLapProgress);
    }

    public void CheckProgress(float progress)
    {
        if(progress >= reqLapProgress)
        {
            //Completed a lap!
            LapCompleted();
            Debug.Log("Reached the required amount of progress");
        }
    }

    public void LapCompleted()
    {
        //update laps 
        laps++; //or laps += 1;
        //update curProgress 
        curLapProgress = 0f;
        //update reqProgress 
        reqLapProgress *= 1.15f;
        //update speed - speed *= 1.4f;
        Debug.Log("Completed " + laps + " laps");

    } 
}