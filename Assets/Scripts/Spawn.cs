using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] objs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sp());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator sp()
    {
        yield return new WaitForSeconds(Random.Range(3, 5));
        Instantiate(objs[Random.Range(0, 3)], transform.position, Quaternion.identity);
        StartCoroutine(sp());
    }

}
