using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public GameObject canvasManager;
    public GameObject waves;

    public void MouseClick(string buttonType)
    {

        if (buttonType == "Light 1")
        {
            player.GetComponent<Shooting>().setFireRate(4);
            player.GetComponent<Shooting>().setBulletForce(35);
            player.GetComponent<PlayerMovement2>().setSpeed(25);
            bullet.GetComponent<Bullet>().setDamage(8);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(1);
            //player.SetActive(true);
            waves.SetActive(true);
        }
        
        if (buttonType == "Balanced")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(2);
            //player.SetActive(true);
            waves.SetActive(true);
        }
        
        if (buttonType == "Heavy 1")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(3);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Light 2")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(4);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Balanced Light 1")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(5);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Balanced Heavy 1")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(6);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Heavy 2")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(7);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Sniper")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            //canvasManager.GetComponent<canvasManager>().setCanvNum(1);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Light 3")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            //canvasManager.GetComponent<canvasManager>().setCanvNum(1);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Balanced Light 2")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            //canvasManager.GetComponent<canvasManager>().setCanvNum(1);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Balanced Heavy 2")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            //canvasManager.GetComponent<canvasManager>().setCanvNum(1);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Heavy 3")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            //canvasManager.GetComponent<canvasManager>().setCanvNum(1);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Battle Tank")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            //canvasManager.GetComponent<canvasManager>().setCanvNum(1);
            //player.SetActive(true);
            waves.SetActive(true);
        }

    }


    void Update()
    {

    }
}
