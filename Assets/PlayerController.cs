using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 touchPadAction;

    public Camera mCamera;

    Rigidbody mRigidBody;

    Vector2 touchpadValue;

    public float MoveSpeed = 5;

    private void Start()
    {
        mRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        touchpadValue = touchPadAction.GetAxis(SteamVR_Input_Sources.Any);
    }

    private void FixedUpdate()
    {
        Vector3 newPosition = new Vector3(touchpadValue.x, 0, touchpadValue.y);
        newPosition = mCamera.transform.TransformDirection(newPosition);
        if (newPosition.sqrMagnitude > 0) {
            mRigidBody.MovePosition((transform.position + newPosition * MoveSpeed * Time.fixedDeltaTime)) ;
        }
    }

}
