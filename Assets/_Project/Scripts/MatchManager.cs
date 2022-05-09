using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MatchManager : MonoBehaviour
{
    
    public string CurrentPlayerTurn => _currentPlayerTurn;
    
    [SerializeField] Player _player1;
    [SerializeField] Player _player2;
    [SerializeField] string _currentPlayerTurn;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        if(string.IsNullOrEmpty(_currentPlayerTurn)){
            _currentPlayerTurn = _player1.Name;
        }
        OnNewTurn?.Invoke(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndTurn(){
        if(_currentPlayerTurn.Equals(_player1.Name)){
            Debug.Log(_player2.Name);
            _currentPlayerTurn = _player2.Name;
        }
        else if(_currentPlayerTurn.Equals(_player2.Name)){
            _currentPlayerTurn = _player1.Name;
        }
        OnNewTurn?.Invoke(this);
    }

    public static Action<MatchManager> OnNewTurn; 
}
