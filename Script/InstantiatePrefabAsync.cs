using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class InstantiatePrefabAsync : MonoBehaviour
{ 
    public GameObject prefab;
   public AssetReference addressablePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void instantiateprefab()
    {
        Instantiate(prefab);
    }

    public void addressableinstnatiateprefab()
    {
        Addressables.InstantiateAsync(addressablePrefab);
    }
}
