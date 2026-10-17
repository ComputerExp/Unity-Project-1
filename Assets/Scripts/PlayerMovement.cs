using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    private void Update()
    {
        // float h = 0f;
        // float v = 0f;
        // if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed) h -= 1f;
        // if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed) h += 1f;
        // if (Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed) v += 1f;
        // if (Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed) v -= 1f;
        // transform.position += Vector3.right * (speed * Time.deltaTime);
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 pos = transform.position;
        pos.x += h * speed * Time.deltaTime;
        pos.y += v * speed * Time.deltaTime;
        transform.position = pos;
    }
} // Class
