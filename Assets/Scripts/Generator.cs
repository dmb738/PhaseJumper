using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public GameObject platform;
	public GameObject platform2;
    public GameObject armor;
    public GameObject enemy;
	public Transform generationPoint;
	public float distanceBetween;

    // Update is called once per frame
    void Update() {
        if (transform.position.y < generationPoint.position.y)
        {
            SpawnPlatform();
			SpawnPlatform2 ();
            // Armor spawn appriximately 15% of the time
            if (Random.value > .85)
            {
                SpawnArmor();
            }
            // Enemies spawn approximately 10% of the time
            if (Random.value > .9)
            {
                SpawnEnemy();
            }
        }
    }

    void SpawnPlatform()
    {
        transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(0f, 2.0f) + distanceBetween, transform.position.z);
        distanceBetween += 1.0f;

        Instantiate(platform, transform.position, transform.rotation);
    }
	void SpawnPlatform2()
	{
		transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(0f, 2.0f) + distanceBetween, transform.position.z);
		distanceBetween += 1.0f;

		Instantiate(platform2, transform.position, transform.rotation);
	}

    void SpawnArmor()
    {
        transform.position = new Vector2(Random.Range(-5.0f, 5.0f), Random.Range(0f, 2.0f) + distanceBetween);
        distanceBetween += 1;

        Instantiate(armor, transform.position, transform.rotation);
    }

    void SpawnEnemy()
    {
        transform.position = new Vector2(Random.Range(-5.0f, 5.0f), Random.Range(0f, 2.0f) + distanceBetween);
        distanceBetween += 1;

        Instantiate(enemy, transform.position, transform.rotation);
    }
}
