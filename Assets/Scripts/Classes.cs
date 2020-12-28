using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Classes : MonoBehaviour
{
    [SerializeField]
    private GameObject UpgradeMenu;

    [SerializeField]
    public int startCurrency;
    public int Currency;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ToggleUpgradeMenu();
        }
    }

    private void ToggleUpgradeMenu()
    {
        UpgradeMenu.SetActive(!UpgradeMenu.activeSelf);
    }
}
