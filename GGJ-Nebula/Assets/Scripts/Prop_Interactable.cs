using UnityEngine;

public class Prop_Interactable : MonoBehaviour
{
    public int playerLayer = 8;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == playerLayer)
        {
            if (!collision.GetComponent<PlayerController>().tieneobjeto)
            {
                if (collision.GetComponent<PlayerController>().puedeCoger)
                {
                    collision.GetComponent<PlayerController>().tieneobjeto = true;
                    collision.GetComponent<PlayerController>().puedeCoger = false;
                    Destroy(gameObject);
                }
                else
                {
                    Debug.Log("NO PUEDES COGER EL OBJETO");
                }
            }
        }
    }
}
