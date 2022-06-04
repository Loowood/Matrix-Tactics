using UnityEngine;
using UnityEngine.InputSystem;

public class CameraHandler : MonoBehaviour
{
    public float rotationSpeed = 0.3f;
    public float displacementSpeed = 0.1f;
    public float ZoomSpeed = 0.02f;

    bool fistFrame = true;

    PlayerControls playerControls;

    private void Awake() {
        playerControls = new PlayerControls();
    }

    private void OnEnable() {
        playerControls.Player.Pan.performed += CheckPanAction;
        playerControls.Player.Move.performed += CheckMoveAction;
        playerControls.Player.Zoom.performed += CheckZoomAction;
        playerControls.Player.Enable();
    }

    private void OnDisable() {
        playerControls.Player.Pan.performed -= CheckPanAction;
        playerControls.Player.Move.performed -= CheckMoveAction;
        playerControls.Player.Zoom.performed -= CheckZoomAction;
    }

    private void CheckPanAction(InputAction.CallbackContext ctx){
        //skip the first input 
        if(fistFrame){
            fistFrame = false;
            return;
        }
        if(playerControls.Player.ActivatePan.IsPressed()){
            PanObject(ctx);
        }
    }

    private void CheckMoveAction(InputAction.CallbackContext ctx){
        if(playerControls.Player.ActivateMove.IsPressed()){
            MoveObject(ctx);
        }
    }

    private void CheckZoomAction(InputAction.CallbackContext ctx){
        ZoomObject(ctx);
    }

    private void PanObject(InputAction.CallbackContext ctx){
        Vector2 input = ctx.ReadValue<Vector2>();
        transform.eulerAngles += rotationSpeed * new Vector3(-input.y, input.x, 0f);
    }

    private void MoveObject(InputAction.CallbackContext ctx){
        Vector2 input = ctx.ReadValue<Vector2>();
        transform.Translate(displacementSpeed * new Vector3(-input.x, -input.y, 0f));
    }

    private void ZoomObject(InputAction.CallbackContext ctx){
        Vector2 input = ctx.ReadValue<Vector2>();
        transform.Translate(ZoomSpeed * new Vector3(0f, 0f, input.y));
    }
}
