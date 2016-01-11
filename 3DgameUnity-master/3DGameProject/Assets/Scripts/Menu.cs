using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Menu : MonoBehaviour
{

    public Button MenuButton;
    // Use this for initialization
    void Start()
    {
        MenuButton = MenuButton.GetComponent<Button>();
    }

    // Update is called once per frame
    public void PressMenu()
    {
        MenuButton.enabled = false;
        Application.LoadLevel("Menu");
    }
}
