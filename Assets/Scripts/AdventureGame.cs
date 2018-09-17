using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] TMP_Text titleComponent;
    [SerializeField] TMP_Text textComponent;
    [SerializeField] State startingState;

    State state;

    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        titleComponent.text = state.GetStateTitle();
    }

    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        /* Loop through each state and check whether current 
        input corresponds to that state. If this happens on each
        update, seems like it would be very inefficient? */
        for (int i = 0; i < nextStates.Length; i++) 
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            { state = nextStates[i]; }
        }

        textComponent.text = state.GetStateStory();
        titleComponent.text = state.GetStateTitle();
    }
}
