using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public GameObject player;

    public void MouseClick(string buttonType)
    {
        
        if (buttonType == "Light 1")
        {
            player.GetComponent<Shooting>().setFireRate(13);
        }
        /*
        if (buttonType == "Balanced")
        {

        }
        
        if (buttonType == "Heavy 1")
        {

        }
        
        if (buttonType == "")
        {

        }
        
        if (buttonType == "")
        {

        }

        if (buttonType == "")
        {

        }

        if (buttonType == "")
        {

        }

        if (buttonType == "")
        {

        }
        */
    }


    void Update()
    {

    }
}
