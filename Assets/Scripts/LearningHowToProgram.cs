using System;
using UnityEngine;

public class LearningHowToProgram:MonoBehaviour
{
    public float Speed { get; set; }
    
    private void Start()
    {
        Speed = 10;
        print("Speed = " + Speed);
    }
}
