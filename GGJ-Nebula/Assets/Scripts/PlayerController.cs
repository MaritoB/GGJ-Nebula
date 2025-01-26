using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int vida = 1;
    public bool recibeDaño = false;


    private void Update()
    {
        if (recibeDaño)
        {
            RecibeDaño();
        }
    }
    public void RecibeDaño()
    {
        vida = 0;
        //Paro tiempo
        SceneManager.LoadScene("FinalMenu");
    }

    
}
