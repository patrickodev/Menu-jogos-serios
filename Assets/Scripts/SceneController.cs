using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToComputer()
    {
        Data.VerificadorPesquisa++;
        Debug.Log(Data.VerificadorPesquisa);
        SceneManager.LoadScene("Computer");
    }

    public void goToDoor()
    {
        if (Data.Pesquisou > 0)
        {
            SceneManager.LoadScene("Door");
        }
        else
        {
            SceneManager.LoadScene("Door2");
        }
    }

    public void goToUrna()
    {
        SceneManager.LoadScene("Urna");
    }

    public void goToUrna1()
    {
        SceneManager.LoadScene("Urna 1");
    }

    public void goToUrna2()
    {
        SceneManager.LoadScene("Urna 2");
    }

    public void goToCandidato1()
    {
        Data.Pesquisou++;    
        SceneManager.LoadScene("Candidato1");
    }

    public void goToCandidato2()
    {
        Data.Pesquisou++;
        SceneManager.LoadScene("Candidato2");
    }

    public void goToObra()
    {
        Data.VerificadorPesquisa++;
        Debug.Log(Data.VerificadorPesquisa);
        SceneManager.LoadScene("ObraInacabada");
    }

    public void goToPosto()
    {
        Data.VerificadorPesquisa++;
        Debug.Log(Data.VerificadorPesquisa);
        SceneManager.LoadScene("Posto");
    }

    public void verificadorDeFinal()
    {
        if (Data.VerificadorPesquisa > 0)
        {
            
        }
    }

}
