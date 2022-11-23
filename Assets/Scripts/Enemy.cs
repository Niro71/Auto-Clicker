using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public int curHp;
    public int maxHp;
    public int moneyToGive;
    public Image healthBarFill;

    public void Damage() {
        curHp--;
        healthBarFill.fillAmount = (float)curHp / (float)maxHp;

        if(curHp <= 0) {    //can also use isKilled curHp <= 0 with PubBool
            Killed();
        }

    }
    public void Killed() {
        GameManager.instance.AddMoney(moneyToGive);
        EnemyManager.instance.ReplaceEnemy(gameObject);
    }
    
}
