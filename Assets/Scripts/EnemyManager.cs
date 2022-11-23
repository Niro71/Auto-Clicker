using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    
    public GameObject[] enemyPrefabs;
    public Enemy curEnemy;
    
    public Transform canvas;

    public static EnemyManager instance;

    void Awake() {
        instance = this;
    }

    //Spawn Enemy
    public void SpwanEnemy() {
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0 , enemyPrefabs.Length)];
        GameObject obj = Instantiate(enemyToSpawn, canvas);

        curEnemy = obj.GetComponent<Enemy>();
    }

    //Repalce Enemy 
    public void ReplaceEnemy(GameObject enemy) {
        Destroy(enemy);
        SpwanEnemy();
    }

}
