using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController), typeof(Animator), typeof(AudioSource))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float walkSpeed = 2f;
    public float runSpeed = 5f;
    public float rotationSpeed = 10f;  
    public float jumpHeight = 1.2f;
    public float gravity = -9.81f;

    [Header("Audio Clips")]
    public AudioClip footstepSound;
    public AudioClip jumpSound;

    private CharacterController controller;
    private Animator animator;
    private AudioSource audioSource;
    private PlayerControls inputActions;
    private Transform mainCamera;

    private Vector3 velocity;
    private bool isGrounded;
    private Vector2 moveInput;
    private bool isRunning;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        
        if (Camera.main != null)
        {
            mainCamera = Camera.main.transform;
        }

        inputActions = new PlayerControls();
        
        inputActions.Player.Jump.performed += ctx => PerformJump();
        inputActions.Player.Run.performed += ctx => isRunning = true;
        inputActions.Player.Run.canceled += ctx => isRunning = false;
    }

    void OnEnable()
    {
        inputActions.Enable();
    }

    void OnDisable()
    {
        inputActions.Disable();
    }

    void Update()
    {
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        moveInput = inputActions.Player.Move.ReadValue<Vector2>();
        float currentSpeed = isRunning ? runSpeed : walkSpeed;

        Vector3 camForward = mainCamera.forward;
        Vector3 camRight = mainCamera.right;
        
        camForward.y = 0f;
        camRight.y = 0f;
        camForward.Normalize();
        camRight.Normalize();

        Vector3 moveDir = camForward * moveInput.y + camRight * moveInput.x;

        controller.Move(moveDir * currentSpeed * Time.deltaTime);

        if (moveDir != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDir);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

        float movementMagnitude = moveInput.magnitude; 
        float animationSpeed = movementMagnitude * (isRunning ? 1f : 0.5f);
        animator.SetFloat("Speed", animationSpeed, 0.1f, Time.deltaTime);

        
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void PerformJump()
    {
        if (isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            animator.SetTrigger("Jump");

            if (jumpSound != null)
            {
                audioSource.PlayOneShot(jumpSound);
            }
        }
    }

public void PlayFootstep()
{
    bool isMoving = moveInput.sqrMagnitude > 0.01f;

    if (isGrounded && isMoving)
    {
        if (footstepSound != null)
        {
            audioSource.pitch = Random.Range(0.85f, 1.15f);
            audioSource.PlayOneShot(footstepSound);
        }
    }
}
}