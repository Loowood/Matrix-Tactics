using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPlayerTurn : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    public void OnEnable(){
        MatchManager.OnNewTurn += updateCurrentPlayerText;
    }

    public void OnDisable(){
        MatchManager.OnNewTurn -= updateCurrentPlayerText;
    }

    void updateCurrentPlayerText(MatchManager matchManager){
        textMeshPro.text = "It is the turn of : " + matchManager.CurrentPlayerTurn;
    }
}
