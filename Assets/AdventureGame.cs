using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;

    // Use this for initialization
    void Start()
    {
        textComponent.text = 
            "Welcome to the text adventure." +
            Environment.NewLine + Environment.NewLine +
            @"You are sitting in front of a computer, basking in the green glow of the screen. Your belly is still full from supper, and you feel vague and lackadaiscal. Suddenly an idea pops into your head: 'I should program something!' Do you" +
            Environment.NewLine + Environment.NewLine +
            "\t(A) fire up Visual Studio Code and begin programming, or" +
            Environment.NewLine + 
            "\t(B) get up from the computer and play Persona 5?";
    }
    // Update is called once per frame
    void Update()
    {

    }
}
