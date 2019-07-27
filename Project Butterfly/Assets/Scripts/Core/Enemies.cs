using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject[] sPrefabs;
    public GameObject[] enemy;
    private Vector3 spawnObstaclePosition;

   
    void Update()
    {
        float distanceToHorizon = Vector2.Distance(player.gameObject.transform.position, spawnObstaclePosition);
        if (distanceToHorizon < 10)//hoger getal en ze worden verderweg al gerenderd
        {
            //SpawnCoins();
            SpawnEnemy();
        }

        void SpawnCoins()
        {
            spawnObstaclePosition = new Vector3( spawnObstaclePosition.x + Random.Range(0.1f,10f),Random.Range(-1,2),0);
            
            Instantiate(sPrefabs[(Random.Range(0, sPrefabs.Length))], spawnObstaclePosition, Quaternion.identity); //Quaternion zorgt voor de ingestelde draai en alles
        }
         void SpawnEnemy()
        {

            spawnObstaclePosition = new Vector3(spawnObstaclePosition.x + Random.Range(0.1f, 5f), -0.8f, 0);
            Instantiate(enemy[(Random.Range(0, enemy.Length))], spawnObstaclePosition, Quaternion.identity); //Quaternion zorgt voor de ingestelde draai en alles

        }
    }
    
}
