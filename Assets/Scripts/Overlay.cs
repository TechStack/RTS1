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
            int XslotPosition = -545;

            GUI.DrawTexture(new Rect((Screen.width ) / 2 + XslotPosition
                , Screen.height- inventory.Slot1.height , inventory.Slot1.width , inventory.Slot1.height ), inventory.Slot1);
            XslotPosition = XslotPosition +inventory.Slot1.height + 5;

            GUI.DrawTexture(new Rect((Screen.width) / 2 + XslotPosition
                , Screen.height - inventory.Slot1.height, inventory.Slot1.width, inventory.Slot1.height), inventory.Slot1);
            XslotPosition = XslotPosition + inventory.Slot1.height + 5;

            GUI.DrawTexture(new Rect((Screen.width) / 2 + XslotPosition
                , Screen.height - inventory.Slot1.height, inventory.Slot1.width, inventory.Slot1.height), inventory.Slot1);
            XslotPosition = XslotPosition + inventory.Slot1.height + 5;

            GUI.DrawTexture(new Rect((Screen.width) / 2 + XslotPosition
                , Screen.height - inventory.Slot1.height, inventory.Slot1.width, inventory.Slot1.height), inventory.Slot1);
            XslotPosition = XslotPosition + inventory.Slot1.height + 5;

            GUI.DrawTexture(new Rect((Screen.width) / 2 + XslotPosition
                , Screen.height - inventory.Slot1.height, inventory.Slot1.width, inventory.Slot1.height), inventory.Slot1);
            XslotPosition = XslotPosition + inventory.Slot1.height + 5;

            GUI.DrawTexture(new Rect((Screen.width) / 2 + XslotPosition
                , Screen.height - inventory.Slot1.height, inventory.Slot1.width, inventory.Slot1.height), inventory.Slot1);
            XslotPosition = XslotPosition + inventory.Slot1.height + 5;

            GUI.DrawTexture(new Rect((Screen.width) / 2 + XslotPosition
                , Screen.height - inventory.Slot1.height, inventory.Slot1.width, inventory.Slot1.height), inventory.Slot1);
            XslotPosition = XslotPosition + inventory.Slot1.height + 5;

            GUI.DrawTexture(new Rect((Screen.width) / 2 + XslotPosition
                , Screen.height - inventory.Slot1.height, inventory.Slot1.width, inventory.Slot1.height), inventory.Slot1);


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
