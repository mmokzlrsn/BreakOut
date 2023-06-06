using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PowerUpManager : MonoBehaviour
{
    public static PowerUpManager instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] private Ball _ball;
    [SerializeField] private Paddle _paddle;
 

    public void ApplyPowerUpToBall(PowerUp powerUp)
    {
        if (powerUp != null)
        {
             powerUp.ApplyPowerUp(_ball.gameObject);
        }
    }

    public void ApplyPowerUpToPaddle(PowerUp powerUp)
    {
        if (powerUp != null)
        {
            StartCoroutine(powerUp.ApplyPowerUp(_paddle.gameObject));
        }
    }
}
