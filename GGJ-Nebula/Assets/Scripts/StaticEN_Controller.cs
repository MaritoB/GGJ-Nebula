using Unity.VisualScripting;
using UnityEngine;

public class StaticEN_Controller : MonoBehaviour
{
    public GameObject attackasset;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            attackasset.SetActive(true);
            //WaitForSeconds 1f
            
        }
    }

    
}
