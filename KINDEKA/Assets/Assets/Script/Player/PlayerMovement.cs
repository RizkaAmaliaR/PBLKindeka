using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FixedJoystick joystick;
    public float SpeedMove = 5f;
    private CharacterController controller;
    private Animator anim;

    private float _gravity = -9.81f;
    [SerializeField] private float gravityMultiplier = 3.0f;
    private float _velocity;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Apply gravity
        _velocity += _gravity * gravityMultiplier * Time.deltaTime;

        // Calculate movement based on joystick input
        Vector3 Move = transform.right * joystick.Horizontal + transform.forward * joystick.Vertical;

        //Apply gravity to the vertical movement
        Move.y = _velocity;

        //Move the character controller
        controller.Move(Move * SpeedMove * Time.deltaTime);
    }
}
