using UnityEngine;
using System.Collections;

public class BubbleManager : MonoBehaviour
{

    public Bubble[] bubblePrefabs;
    public int numToSpawn;
    public float radiusFromCenter = 3.0f;
    public Transform spawnPoint;
    private Bubble[] bubbles;

    void Start()
    {
        bubbles = new Bubble[numToSpawn];
        for(int i = 0; i < numToSpawn; i++)
        {
            Bubble current = Instantiate(bubblePrefabs[Random.Range(0, bubblePrefabs.Length)]) as Bubble;

            Vector3 currentPos = Vector3.zero;

            currentPos.x += Random.Range(-radiusFromCenter, radiusFromCenter);
            currentPos.y += Random.Range(-radiusFromCenter, radiusFromCenter);
            currentPos.z += Random.Range(-radiusFromCenter, radiusFromCenter);

            current.transform.position = spawnPoint.position + currentPos;

            bubbles[i] = current;
        }
    }

    void Update()
    {
        for(int i = 0; i < bubbles.Length; i++)
        {
            bubbles[i].Grow();
            bubbles[i].Rotate();
        }
    }
}
