using UnityEngine;

public class boat_collectables : MonoBehaviour
{
    public GameObject player;
    public int playerLayer = 8;
    public GameObject victoryMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == playerLayer && collision.GetComponent<PlayerController>().tieneobjeto)
        {
            //CONSIGO UN PUNTO
            SumaPuntuacion(collision.gameObject);
            player = collision.gameObject;
            if (player.GetComponent<PlayerController>().puntuación >= 6)
            {
                Time.timeScale = 0f;
                victoryMenu.SetActive(true);
            }
           
            
        }
    }


    public void SumaPuntuacion(GameObject player)
    {
        player.GetComponent<PlayerController>().puntuación += 1;
        player.GetComponent<PlayerController>().tieneobjeto = false;
        player.GetComponent<PlayerController>().puedeCoger = true;
    }
}
