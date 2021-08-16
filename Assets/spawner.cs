using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private float maxX = 3.15f;
    private float minX = -3.15f;

    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( Spawbomb());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawbomb()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        Instantiate(bomb, new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity);
        StartCoroutine(Spawbomb());
    }
}
