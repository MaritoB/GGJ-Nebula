using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_01_Controller : MonoBehaviour
{
    //public GameObject attackasset;
    public Transform player;
    public float detectionRadius = 5.0f;
    public float speed = 2.0f;

    private Rigidbody2D rb;
    private Vector2 movement;
    public Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceToPlayer < detectionRadius)
        {
            Vector2 direction = (player.position - transform.position).normalized;

            movement = new Vector2(direction.x, direction.y);
        }
        else
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);


    }
    
}
