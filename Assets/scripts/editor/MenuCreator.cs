using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuCreator : MonoBehaviour {

    [MenuItem("GameObject/FurnitureMenu/Category", false, 0)]
    static void CreateCategoryMenu(MenuCommand command)
    {
        Debug.Log("Category Menu");
        GameObject assetSpawner = (GameObject)command.context;
        List<GameObject> spawnList  = GetSpawnList(assetSpawner, "chairs");
    }

    static List<GameObject> GetSpawnList(GameObject spawner, string category)
    {
        switch (category)
        {
            case "chairassets":
                return spawner.GetComponent<SpawnList>().chairs;
            case "drawerassets":
                return spawner.GetComponent<SpawnList>().drawers;
            case "tableassets":
                return spawner.GetComponent<SpawnList>().tables;
            case "sofaassets":
                return spawner.GetComponent<SpawnList>().sofas;
            case "bedassets":
                return spawner.GetComponent<SpawnList>().beds;
            case "storageassets":
                return spawner.GetComponent<SpawnList>().storage;
            case "lightassets":
                return spawner.GetComponent<SpawnList>().lights;
            default:
                return new List<GameObject>();
        }
    }
}
