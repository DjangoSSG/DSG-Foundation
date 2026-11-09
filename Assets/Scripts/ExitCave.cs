using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCave : MonoBehaviour
{
    public DoKeyAnimation DoKeyAnimation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseDown()
    {
        if (DoKeyAnimation.gnomeFree == true)
        {
            Cursor.visible = true; //makes cursor visible in victory scene
            SceneManager.LoadSceneAsync(2); //loads victory scene
        }
    }
}
