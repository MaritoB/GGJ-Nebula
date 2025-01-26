using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class StaticEN_Controller : MonoBehaviour
{
    public GameObject attackasset;
    public Transform player;
    public float detectionRadius = 5.0f;
    public float speed = 2.0f;


    private bool haceDa�o;
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

        animator.SetBool("Attacking", haceDa�o);


    }
    public void Haceda�o()
    {
        if (!haceDa�o)
        {
            haceDa�o = true;
        }
        

    }

    public void DesactivaDa�o()
    {
        haceDa�o = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            collision.gameObject.GetComponent<PlayerController>().RecibeDa�o();
            gameObject.SetActive(false);
            attackasset.SetActive(true);
            StartCoroutine(AttackTime());
            gameObject.SetActive(true);
            attackasset.SetActive(false);
        }
    }

    

    IEnumerator AttackTime()
    {
        yield return new WaitForSeconds(1);
    }

    
}
