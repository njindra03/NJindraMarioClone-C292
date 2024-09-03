using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleGuyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.0f;
    [SerializeField] private float jumpSpeed = 5.0f;
    private Rigidbody2D rb2d;
 
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector2.left);
    }
}
