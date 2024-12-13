using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
     // Lista para armazenar o histórico de cenas
    private static List<int> sceneHistory = new List<int>();

    void Start()
    {
        // Adiciona a cena atual ao histórico
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Evita adicionar a mesma cena mais de uma vez ao histórico
        if (sceneHistory.Count == 0 || sceneHistory[sceneHistory.Count - 1] != currentSceneIndex)
        {
            sceneHistory.Add(currentSceneIndex);
        }
    }

    public void LoadPreviousScene()
    {
        if (sceneHistory.Count > 1)
        {
            // Remove a cena atual do histórico
            sceneHistory.RemoveAt(sceneHistory.Count - 1);

            // Carrega a cena anterior
            int previousSceneIndex = sceneHistory[sceneHistory.Count - 1];
            SceneManager.LoadScene(previousSceneIndex);
        }
        else
        {
            Debug.LogWarning("Não há cena anterior para carregar.");
        }
    }

    public void LoadNextScene(string sceneName)
    {
        // Adiciona a nova cena ao histórico
        int nextSceneIndex = SceneManager.GetSceneByName(sceneName).buildIndex;
        sceneHistory.Add(nextSceneIndex);

        // Carrega a nova cena
        SceneManager.LoadScene(sceneName);
    }
}
