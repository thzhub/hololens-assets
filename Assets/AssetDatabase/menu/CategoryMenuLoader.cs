using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryMenuLoader : MonoBehaviour {

    public GameObject spawner;
    public string category;
    private List<GameObject> furnitures;

	void Start () {
        SpawnList spawnList = spawner.GetComponent<SpawnList>();
        furnitures = spawnList.findBundle(category);

        int i = 0;
        foreach (Transform child in transform)
        {
            if (child.gameObject.name.Equals("Button"))
            {
                if (i < furnitures.Count)
                {
                    GameObject f = furnitures[i];
                    FurnitureProperty properties = spawnList.findAssetProperties(category, f.name);
                    child.gameObject.GetComponent<FurnitureMenuItemProperty>().furnitureProperty.bundle = properties.bundle;
                    child.gameObject.GetComponent<FurnitureMenuItemProperty>().furnitureProperty.assetName = properties.assetName;
                    child.gameObject.GetComponent<FurnitureMenuItemProperty>().furnitureProperty.furnitureType = properties.furnitureType;
                    child.gameObject.GetComponent<Image>().sprite = spawnList.findAssetIcon(category, i);
                    i++;
                }
                else
                {
                    child.gameObject.SetActive(false);
                }
            }
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
