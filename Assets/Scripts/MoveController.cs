using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    float speed = 2.0f;
    public CharacterController characterController;
    float horizontal, vertical;
    Vector3 dir;
    public OVRGrabber RightOVRGrabber;
    bool beginMove = false;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.J))
        //{
        //    speed *= 3;
        //}
        //if (Input.GetKeyUp(KeyCode.J))
        //{
        //    speed = 2.0f;
        //}


        //horizontal = Input.GetAxis("Horizontal") * speed;
        //vertical = Input.GetAxis("Vertical") * speed;
        //dir = transform.forward * vertical + transform.right * horizontal;

        //if (OVRInput.GetDown(OVRInput.Button.One))
        //{
        //    Debug.Log("按键A按下");
        //    speed *= 3;
        //}
        //else
        //{
        //    speed = 2.0f;
        //}
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            speed *= 3;
        }
        if (OVRInput.GetUp(OVRInput.Button.One))
        {
            speed = 2;
        }

        //按键B是否移动
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            beginMove = true;
        }
        dir = RightOVRGrabber.transform.forward;
        if (beginMove)
            characterController.Move(dir * Time.deltaTime);
    }
}
