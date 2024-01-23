using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject SpawnObjectRed;
    public GameObject SpawnObjectBrown;
    public GameObject SpawnObjectGreen;
    float PositionY;
    // Start is called before the first frame update
    void Start()
    {
        prefabList.Add(SpawnObjectRed);
        prefabList.Add(SpawnObjectGreen);
        prefabList.Add(SpawnObjectBrown);
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        int prefabIndex = UnityEngine.Random.Range(0, 3);
        Instantiate(prefabList[prefabIndex], transform.position, transform.rotation);
    }
}
