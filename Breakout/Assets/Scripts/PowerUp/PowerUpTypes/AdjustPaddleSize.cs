using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustPaddleSize : PowerUp
{
    public override IEnumerator ApplyPowerUp(GameObject gameObject)
    {
        var temp = gameObject.transform.localScale;
        gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x * Value, gameObject.transform.localScale.y);
        yield return new WaitForSeconds(Duration);
        gameObject.transform.localScale = temp;

    }

    private void OnDestroy()
    {
        PowerUpManager.instance.ApplyPowerUpToPaddle(this);
    }
}
