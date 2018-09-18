using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

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
        
        // Get user input and try to convert to integer. If the integer corresponds to one of the next states, (converting from 0-based index), set state as corresponding state. We also rule out the case where input is 0, since by default Input.inputString gives 0.
        int input;
        Int32.TryParse(Input.inputString, out input);
        if (0 < input && input - 1 < nextStates.Length) {
            state = nextStates[input - 1];
        }

        textComponent.text = state.GetStateStory();
        titleComponent.text = state.GetStateTitle();
    }
}
