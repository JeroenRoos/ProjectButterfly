using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject[] sPrefabs;
    public GameObject[] enemy;
    private Vector3 spawnObstaclePosition;

    void Update()
    {
        float distanceToHorizon = Vector2.Distance(player.gameObject.transform.position, spawnObstaclePosition);

        //hoger getal en ze worden verderweg al gerenderd
        if (distanceToHorizon < 10)
        {
            //SpawnCoins();

            SpawnEnemy();
        }
    }

    private void SpawnCoins()
    {
        spawnObstaclePosition = new Vector3(spawnObstaclePosition.x + Random.Range(0.1f, 10f), Random.Range(-1, 2), 0);

        //Quaternion zorgt voor de ingestelde draai en alles
        Instantiate(sPrefabs[(Random.Range(0, sPrefabs.Length))], spawnObstaclePosition, Quaternion.identity); 
    }

    private void SpawnEnemy()
    {
        spawnObstaclePosition = new Vector3(spawnObstaclePosition.x + Random.Range(0.1f, 5f), -0.8f, 0);

        //Quaternion zorgt voor de ingestelde draai en alles
        Instantiate(enemy[(Random.Range(0, enemy.Length))], spawnObstaclePosition, Quaternion.identity); 
    }
}
