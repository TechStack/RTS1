using UnityEngine;
using System.Collections;

public class Overlay : MonoBehaviour
{

    public Texture2D crosshairTexture;
    public float crosshairScale = 1;
    public GameObject Player;
    private Inventory inventory;
    void Start()
    {
        inventory = Player.GetComponent<Inventory>();
    }
    void OnGUI()
    {

        if (inventory != null)
        {

        }
        //if not paused
        if (Time.timeScale != 0)
        {
            if (crosshairTexture != null)
                GUI.DrawTexture(new Rect((Screen.width - crosshairTexture.width * crosshairScale) / 2, (Screen.height - crosshairTexture.height * crosshairScale) / 2, crosshairTexture.width * crosshairScale, crosshairTexture.height * crosshairScale), crosshairTexture);
            else
                Debug.Log("No crosshair texture set in the Inspector");
        }
    }
}
