using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSelection : MonoBehaviour
{

    const string CUBE_TAG = "Cube";
    PlayerControls playerControls;

    private void Awake() {
        playerControls = new PlayerControls();
    }

    private void OnEnable() {
        playerControls.Player.Select.performed += Clicked;
        playerControls.Player.Select.canceled += Released;
        playerControls.Player.Enable();
    } 

    private void OnDisable() {
        playerControls.Player.Select.performed -= Clicked;
        playerControls.Player.Select.canceled -= Released;
    }

    private void Clicked(InputAction.CallbackContext ctx){
        MouseSelection(ctx);
    }

    private void Released(InputAction.CallbackContext ctx){
    }

    private void MouseSelection(InputAction.CallbackContext ctx){
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        //Ray ray = Camera.camera.ScreenPointToRay(Mouse.current.position.ReadValue());
        if ( Physics.Raycast (ray, out hit, 100.0f)) {
            Debug.Log("You selected the " + hit.transform.name + " with the tag : " + hit.transform.tag); 
            if(hit.transform.tag == CUBE_TAG){
                Debug.Log("Nice cube you have here"); 
                CubeState cubeState = hit.transform.GetComponentInParent<CubeState>();
                if(cubeState != null){
                    cubeState.HandleSelection();
                }
            }
        }
    }
}
