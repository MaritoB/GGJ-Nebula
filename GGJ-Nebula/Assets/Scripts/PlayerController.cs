using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int vida = 1;
    public bool recibeDamage = false;
    public int puntuación = 0;
    public bool tieneobjeto = false;
    public int layerProps = 6;
    public bool puedeCoger = true;
    public GameObject bolsita;

    private void Update()
    {
        if (recibeDamage)
        {
            RecibeDamage();
        }
        if (tieneobjeto)
        {
            bolsita.gameObject.SetActive(true);
        }
        if (!tieneobjeto)
        {
            bolsita.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            RecibeDamage();

        }
        if (puedeCoger)
        {
            if (collision.gameObject.layer == layerProps)
            {
                //tieneobjeto = true;
            }
        }
        


    }
    public void RecibeDamage()
    {
        vida = 0;
        //Paro tiempo
        SceneManager.LoadScene("FinalMenu");
    }
    public void Cheater()
    {
        puntuación = 6;
        tieneobjeto = true;
    }
    
}
