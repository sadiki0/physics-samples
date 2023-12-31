using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentripetalSpawner : MonoBehaviour
{
    public GameObject obj;

    public uint count;

    public float radius = 20.0f;
    public float deadZone = 15.0f;

    public GameObject planet;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            Vector3 pos = Vector3.right * Random.Range(deadZone, radius);

            GameObject nObj = Instantiate(obj, pos, Quaternion.identity);
            nObj.GetComponent<CentripetalPull>().point = planet.transform;
        }
    }
}
