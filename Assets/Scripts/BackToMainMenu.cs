using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    // Update is called once per frame
}
