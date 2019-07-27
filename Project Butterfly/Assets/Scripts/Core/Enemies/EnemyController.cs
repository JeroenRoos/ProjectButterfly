using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject[] sPrefabs;
    public GameObject[] enemy;
    private Vector3 spawnObstaclePositionEnemy;
    private Vector3 spawnObstaclePositionCoin;

    void Update()
    {
        float distanceToHorizonEnemy = Vector2.Distance(player.gameObject.transform.position, spawnObstaclePositionEnemy);
        float distanceToHorizonCoin = Vector2.Distance(player.gameObject.transform.position, spawnObstaclePositionCoin);

        //hoger getal en ze worden verderweg al gerenderd
        if (distanceToHorizonEnemy < 10)
        {
            SpawnEnemy();
        }

        if (distanceToHorizonEnemy < 10)
        {
            SpawnCoins();
        }
    }

    private void SpawnCoins()
    {
        spawnObstaclePositionCoin = new Vector3(spawnObstaclePositionCoin.x + Random.Range(0.1f, 10f), Random.Range(-0.5f, 0.7f), 0);

        //Quaternion zorgt voor de ingestelde draai en alles
        Instantiate(sPrefabs[(Random.Range(0, sPrefabs.Length))], spawnObstaclePositionCoin, Quaternion.identity); 
    }

    private void SpawnEnemy()
    {
        spawnObstaclePositionEnemy = new Vector3(spawnObstaclePositionEnemy.x +3.5f, -0.8f, 0);

        //Quaternion zorgt voor de ingestelde draai en alles
        Instantiate(enemy[(Random.Range(0, enemy.Length))], spawnObstaclePositionEnemy, Quaternion.identity); 
    }
}
