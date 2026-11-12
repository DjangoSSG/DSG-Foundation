using UnityEngine;

public class GnomeDisappear : MonoBehaviour
{
    public unlockDoor doorScript;
    public GameObject Gnome;
    // Update is called once per frame
    void Update()
    {
        if (doorScript.gnomeGone == true)
        {
            Gnome.SetActive(false);
        }
    }
}
