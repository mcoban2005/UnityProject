using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class FpsInputMovementCC : MonoBehaviour
{
    [Header("Input Actions (New Input System)")]
    public InputActionReference moveAction; // Player/Move (Vector2)
    public InputActionReference lookAction; // Player/Look (Vector2)
    public InputActionReference jumpAction; // Player/Jump (Button)

    [Header("References")]
    public Transform cameraTransform; // child Camera (pitch için)

    [Header("Movement")]
    public float moveSpeed = 5f;
    public float lookSensitivity = 0.08f;
    public float pitchClamp = 85f;

    [Header("Jump/Gravity")]
    public float jumpHeight = 1.5f;
    public float gravity = -20f; // CharacterController için negatif olmalı

    CharacterController controller;

    float yaw;
    float pitch;

    Vector3 velocity; // y sadece gravity/jump için kullanılır

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void OnEnable()
    {
        moveAction?.action.Enable();
        lookAction?.action.Enable();
        jumpAction?.action.Enable();
    }

    void OnDisable()
    {
        moveAction?.action.Disable();
        lookAction?.action.Disable();
        jumpAction?.action.Disable();
    }

    void Update()
    {
        HandleLook();
        HandleMove();
        HandleJumpAndGravity();
    }

    void HandleLook()
    {
        if (lookAction == null || cameraTransform == null) return;

        Vector2 lookDelta = lookAction.action.ReadValue<Vector2>();

        yaw += lookDelta.x * lookSensitivity;
        pitch -= lookDelta.y * lookSensitivity;
        pitch = Mathf.Clamp(pitch, -pitchClamp, pitchClamp);

        transform.rotation = Quaternion.Euler(0f, yaw, 0f);
        cameraTransform.localRotation = Quaternion.Euler(pitch, 0f, 0f);
    }

    void HandleMove()
    {
        if (moveAction == null) return;

        Vector2 moveInput = moveAction.action.ReadValue<Vector2>();
        Vector3 move =
            transform.right * moveInput.x +
            transform.forward * moveInput.y;

        controller.Move(move * moveSpeed * Time.deltaTime);
    }

    void HandleJumpAndGravity()
    {
        // Ground check + gravity integration
        if (controller.isGrounded && velocity.y < 0f)
            velocity.y = -2f;

        if (jumpAction != null && jumpAction.action.WasPressedThisFrame())
        {
            // v = sqrt(2gh) -> gravity negatif olduğu için -2f * gravity kullanıyoruz
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(new Vector3(0f, velocity.y, 0f) * Time.deltaTime);
    }
}

