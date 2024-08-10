using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody playerRigid;
    public float w_speed, wb_speed, olw_speed, ro_speed;
    public Transform playerTrans;

    void FixedUpdate()
    {
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 moveDirection = transform.forward * verticalInput;
        playerRigid.velocity = moveDirection * w_speed * Time.deltaTime;

    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        if (Mathf.Abs(horizontalInput) > 0.01f)
        {
            playerTrans.Rotate(0f, horizontalInput * ro_speed * Time.deltaTime, 0f);
        }

    }
}
