using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    ObjectSpawnPool ObjectSpawnPool;

    private void Start()
    {
        ObjectSpawnPool = ObjectSpawnPool.Instance;   
    }

    void FixedUpdate()
    {
        ObjectSpawnPool.SpawnUitDePool("Coin", transform.position);
    }
}