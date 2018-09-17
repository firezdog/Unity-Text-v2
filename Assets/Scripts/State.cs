using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject 
{

	[TextArea(14,10), SerializeField] string storyText;
    [TextArea, SerializeField] string storyTitle;
    [SerializeField] State[] nextStates;

    public string GetStateStory () 
    {
        return storyText;
    }

    public string GetStateTitle () 
    {
        return storyTitle;
    }

    public State[] GetNextStates ()
    {
        return nextStates;
    }

}