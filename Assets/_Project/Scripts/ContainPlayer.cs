using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainPlayer : MonoBehaviour
{
    [SerializeField]GameObject cube;
    MeshRenderer cubeMeshRenderer;
    bool _isContainingPlayer = false;
    public Player _containedPlayer;
    // Start is called before the first frame update
    void Start()
    {
        cubeMeshRenderer = cube.GetComponent<MeshRenderer>();
        if(_isContainingPlayer == true || _containedPlayer != null){
            ChangeMaterial(_containedPlayer);
        }
    }


    public void ChangeMaterial(Player player){
        //cubeMeshRenderer.material = player.Material;
    }
}
