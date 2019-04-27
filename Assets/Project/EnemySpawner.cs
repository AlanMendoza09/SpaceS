using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;

    private void Start()
    {
        InvokeRepeating("enemyCreator", 0, 3);
    }

    // Update is called once per frame
    private void Update()
    {
        //StartCoroutine(enemyCreator());

    }

    public void enemyCreator()
    {
        Instantiate(enemyPrefab, new Vector3(4, 0, 0), Quaternion.identity);
    }
}
