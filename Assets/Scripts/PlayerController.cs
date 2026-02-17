using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;
using TMPro; 


public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    public float jumpForce = 15f;
    public float movementX;
    public float movementY;
    private int count;

    public AudioSource coinSound;

    public TextMeshProUGUI countText;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count =0; 
        SetCountText();
    }

    // void OnMove(InputValue movementValue)
    // {
    //     Vector2 movementVector = movementValue.Get<Vector2>();
    //     movementX = movementVector.X;
    //     movementY = movementVector.y;
    // }

    void SetCountText()
    {
        countText. text = "Count: " + count.ToString();
    }

    void Update()
    {
        // Makes the Player jump
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    void OnTriggerEnter(Collider other) 
    {
        // IMPORTANT: Make sure your coin tag is exactly "Pickup" in Unity!
        if (other.gameObject.CompareTag("PickUp"))
        {
            if (coinSound != null)
            {
                coinSound.Play();
            }

            other.gameObject.SetActive(false);
            count++;

            SetCountText();
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    
}
