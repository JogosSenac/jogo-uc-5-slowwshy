using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
  public void LoadPlay()
  {
    SceneManager.LoadScene("Fase 1");
  }
  public void Quit()
  {
    Application.Quit();

    Debug.Log("Tu saiu");
  }
  public void config()
  {
    SceneManager.LoadScene("Configurações");
  }
  public void Menu()
  {
    SceneManager.LoadScene("Menu");
  }
}
