using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AdventureGame : MonoBehaviour
{
   [SerializeField] Text textComponent;
   [SerializeField] State startingState;

    State state;

    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStoryState();
    }

    // Update is called once per frame
    void Update()
    {
        ManangeStates();


    }

    private void ManangeStates()
    {
        var nextStates = state.GetNextState();

        for(int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }
        textComponent.text = state.GetStoryState();
    }
}
