using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player
{

    public string Name => _name;
    public Material Material => _material;
    [SerializeField]
    string _name;
    [SerializeField]
    Material _material;

    
    public Player(string name, Material material){
        _name = name;
        _material = material;
    }
}
