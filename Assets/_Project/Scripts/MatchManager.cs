using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchManager : MonoBehaviour
{

    [SerializeField] Player _player1;
    [SerializeField] Player _player2;

    [SerializeField] Material player1Material;
    [SerializeField] Material player2Material;
    // Start is called before the first frame update
    void Start()
    {
        _player1 = new Player("Player 1", player1Material);
        _player2 = new Player("Player 2", player2Material);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
