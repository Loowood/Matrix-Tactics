using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeState : MonoBehaviour
{
    [SerializeField] int _x;
    [SerializeField] int _y;
    [SerializeField] int _z;

    public int X => _x;
    public int Y => _y;
    public int Z => _z;

    [SerializeField] int _type;
    public int Type => _type;
    public enum cubeType{
        Face,
        Vertex
    }

    [SerializeField] Player _containedPlayer;
    public Player ContainedPlayer => _containedPlayer;
    public bool IsContainingPlayer => _containedPlayer != null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setcoordonates(int x, int y, int z){
        _x = x;
        _y = y;
        _z = z;
    }

    public void setContainedPlayer(Player player){
        _containedPlayer = player;
    }

    public void unsetContainedPlayer(){
        _containedPlayer = null;
    }
    public void setType(int type){
        _type = type;
    }

}
