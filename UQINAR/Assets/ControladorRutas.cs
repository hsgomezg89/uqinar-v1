using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorRutas : MonoBehaviour
{
    /*
     * Metodo que permite cambiar de escena al momento de dar click a un boton
     */
    public void SelecionarRuta(string nameRuta)
    {
        SceneManager.LoadScene(nameRuta);
    }

    /*
     * Metodo que permite salir de la aplicacion
     */
    public void Exit()
    {
        Application.Quit();
    }

}
