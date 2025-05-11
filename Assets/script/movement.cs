using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
     public UI_Inventory uiinventory;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    private Animator PlayerAnim;

    private inventory Inventory;
    // Start is called before the first frame update

    private void Awake()
    {
        Inventory = new inventory();

        uiinventory.SetInventory(Inventory);
    }
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
        PlayerAnim.SetFloat("left", moveY);
        PlayerAnim.SetFloat("Speed", moveInput.sqrMagnitude);

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }
}
