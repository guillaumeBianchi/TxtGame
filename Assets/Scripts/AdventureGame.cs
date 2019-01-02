using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class AdventureGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;

    [SerializeField] State startingState;

    State state;

    void Start()
    {
        DisplayStoryText(startingState);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            DisplayStoryText(state.NextStates[0]);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(state.NextStates.Length > 1)
                DisplayStoryText(state.NextStates[1]);
        }
    }

    private void DisplayStoryText(State _state)
    {
        state = _state;
        textComponent.text = state.StoryText;
    }
}
