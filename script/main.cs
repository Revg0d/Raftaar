using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitgame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}