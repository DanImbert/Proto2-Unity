﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public List<GameObject> animalPrefabs;
	private float spawnRangeX = 20;
	private float spawnPosZ = 20;
	private float startDelay = 2;
	private float spawnInterval = 1.5f;

	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void SpawnRandomAnimal()
	{
		if (animalPrefabs.Count == 0)
		{
			Debug.LogWarning("No animal prefabs available to spawn.");
			return;
		}

		int animalIndex = Random.Range(0, animalPrefabs.Count);
		if (animalPrefabs[animalIndex] == null)
		{
			Debug.LogWarning("Animal prefab at index " + animalIndex + " is null.");
			return;
		}

		Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
		Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
	}
}
