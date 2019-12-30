using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossCollision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name.Contains("Ghost"))
        {
            AudioManager.Instance.PlaySingle("SFX_EnemySlain");
            col.gameObject.SetActive(false);
            Destroy(col.gameObject);
            GameManager.Instance.GhostKilled();
        }
    }
}
