using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    public GameObject Inventory;

    private Animator PlayerAnim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PlayerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(moveX, moveY).normalized;

        PlayerAnim.SetFloat("right", moveX);
        PlayerAnim.SetFloat("Speed", moveInput.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (Inventory != null)
            {
                Inventory.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Inventory != null)
            {
                Inventory.SetActive(false);
            }
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }
}
