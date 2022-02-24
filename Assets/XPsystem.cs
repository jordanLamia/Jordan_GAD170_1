using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPsystem : MonoBehaviour
{
    // making base stat variable
    public int Level;
    public int curEXP;
    public int reqEXP;
    
    public float Health;
    public float Attack;
    public float Defense;
    public float Speed;

    
    // function that initilizes stats.
   public void InitialStats()
    {
        // Level stats and XP
        Level = 1;
        curEXP = 0;
        reqEXP = 1000;
        
        // Base stats.
        Health = 50f;
        Attack = 10f;
        Defense = 5f;
        Speed = 7f;

        Debug.Log("Set Stats");

    }

// Add 3 Triggered interactions through keypress
    public void Interaction()
    {
        // Pressing E runs GainXP(), sets amount of EXP to gain on press.
        if (Input.GetKeyUp(KeyCode.E))
        {
            GainXP(250);
            Debug.Log("Pressed Key: E");
        }
        
        // Pressing X runs the LevelUp() function.
        if (Input.GetKeyUp(KeyCode.X))
        {
            LevelUp();
            Debug.Log("Pressed Key: X");
        }
        
        // Pressing R runs InitialStats() reseting stats back to base stats.
        if (Input.GetKeyUp(KeyCode.R))
        {
            InitialStats();
            Debug.Log("Pressed Key: R");
        }
    }

    // Adds amount to curEXP.
    public void GainXP(int amount)
    {
        curEXP += amount;

    }
    
    // Checks if curEXP is equal to or larger then reqEXP.
    // Incrments level by 1 and reEXP by 250 resets curEXP,
    // and runs the IncreaseStats() function.
    public void LevelUp()
    {
        //
        if (curEXP >= reqEXP)
        {
            Level += 1;
            reqEXP += 250;
            curEXP = 0;
            IncreaseStats();
        }

    }

    // Sets how much to increase stats by on level.
    public void IncreaseStats()
    {
        
        Health += 10f;
        Attack += 1f;
        Defense += 0.5f;
        Speed += 0.5f;
        
    }
 
    // Initializes base stats.
    void Awake()
    {
        InitialStats();
        Debug.Log("Stat Script Loaded");
    }

    // Runs Interaction on each frame to check for key presses.
    void Update()
    {
        Interaction();
    }

}
   
