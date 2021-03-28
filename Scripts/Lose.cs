using UnityEngine;

public class Lose : MonoBehaviour
{

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "Game Over. Click to try again"))
        {
            Utilities.RestartLevel(0);
        }
    }

}
