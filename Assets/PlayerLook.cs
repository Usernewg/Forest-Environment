using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    public InputActionAsset inputActions;
    public float sensitivity = 2f;
    private InputAction lookAction;
    private float verticalRotation = 0f;

    void OnEnable()
    {
        // Get the "look" action from the "Player" action map
        lookAction = inputActions.FindActionMap("Player").FindAction("look");
        lookAction.Enable();
    }

    void OnDisable()
    {
        lookAction.Disable();
    }

    void Update()
    {
        Vector2 lookInput = lookAction.ReadValue<Vector2>();

        // Horizontal (Y axis)
        transform.Rotate(Vector3.up * lookInput.x * sensitivity * Time.deltaTime);

        // Vertical (X axis)
        verticalRotation -= lookInput.y * sensitivity * Time.deltaTime;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        Camera.main.transform.localEulerAngles = new Vector3(verticalRotation, Camera.main.transform.localEulerAngles.y, 0f);
    }
}
