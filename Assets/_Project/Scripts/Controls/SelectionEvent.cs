using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SelectionEvent : MonoBehaviour
{
    public static SelectionEvent current;

    private void Awake(){
        current = this;
    }

    public event Action<CubeState> OnCubeSelection;

    public void CubeSelection(CubeState cubeState){
        if(OnCubeSelection != null){
            OnCubeSelection(cubeState);
        }
    }
}
