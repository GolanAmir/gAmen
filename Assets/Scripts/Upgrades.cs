using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public Transform bulletSize;
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
            bulletSize.localScale = new Vector3(0.3f, 0.3f, 0);
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
            player.GetComponent<Shooting>().setFireRate(1.7f);
            player.GetComponent<Shooting>().setBulletForce(20);
            player.GetComponent<Shooting>().setShooterCounter(1);
            player.GetComponent<PlayerMovement2>().setSpeed(15);
            bullet.GetComponent<Bullet>().setDamage(10);
            bulletSize.localScale = new Vector3(0.7f, 0.7f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(3);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Light 2")
        {
            player.GetComponent<Shooting>().setFireRate(9);
            player.GetComponent<Shooting>().setBulletForce(40);
            player.GetComponent<PlayerMovement2>().setSpeed(30);
            bullet.GetComponent<Bullet>().setDamage(6);
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
            player.GetComponent<Shooting>().setBulletForce(22);
            player.GetComponent<Shooting>().setShooterCounter(2);
            player.GetComponent<PlayerMovement2>().setSpeed(15);
            bullet.GetComponent<Bullet>().setDamage(13);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(7);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Sniper")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(60);
            player.GetComponent<PlayerMovement2>().setSpeed(35);
            bullet.GetComponent<Bullet>().setDamage(50);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            //canvasManager.GetComponent<canvasManager>().setCanvNum(1);
            //player.SetActive(true);
            waves.SetActive(true);
        }

        if (buttonType == "Light 3")
        {
            player.GetComponent<Shooting>().setFireRate(15);
            player.GetComponent<Shooting>().setBulletForce(45);
            player.GetComponent<PlayerMovement2>().setSpeed(35);
            bullet.GetComponent<Bullet>().setDamage(6);
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
