using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject space;
    public GameObject[] coins;
    public GameObject[] enemies;


    private Vector3 spawnObstaclePositionEnemy;
    private Vector3 spawnObstaclePositionCoin;
    private Vector3 spaceSpawnPos;
    private bool spaceBounce = false;


    void Update()
    {
        float distanceToHorizonEnemy = Vector2.Distance(player.gameObject.transform.position, spawnObstaclePositionEnemy);
        float distanceToHorizonCoin = Vector2.Distance(player.gameObject.transform.position, spawnObstaclePositionCoin);

        //hoger getal en ze worden verderweg al gerenderd
        if (distanceToHorizonEnemy < 10)
        {
            SpawnEnemy();
        }

        if (distanceToHorizonCoin < 10)
        {
            SpawnCoins();
        }
        if(!spaceBounce && player.gameObject.transform.position.y >= 0.6 )
        {
            spaceSpawnPos = new Vector3(player.gameObject.transform.position.x+3.3f, 3, 0);
            Instantiate(space, spaceSpawnPos, Quaternion.identity);
            spaceBounce = true;
        }
        if(player.gameObject.transform.position.y < 0.6)
        {
            spaceBounce = false;
        }

    }

    private void SpawnCoins()
    {
        spawnObstaclePositionCoin = new Vector3(spawnObstaclePositionCoin.x + Random.Range(0.1f, 10f), Random.Range(-0.5f, 0.7f), 0);

        //Quaternion zorgt voor de ingestelde draai en alles
        Instantiate(coins[(Random.Range(0, coins.Length))], spawnObstaclePositionCoin, Quaternion.identity); 
    }

    private void SpawnEnemy()
    {
        spawnObstaclePositionEnemy = new Vector3(spawnObstaclePositionEnemy.x +3.5f, -0.8f, 0);

        //Quaternion zorgt voor de ingestelde draai en alles
        Instantiate(enemies[(Random.Range(0, enemies.Length))], spawnObstaclePositionEnemy, Quaternion.identity); 
    }
}
