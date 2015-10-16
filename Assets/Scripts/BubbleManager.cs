using UnityEngine;
using System.Collections;

public class BubbleManager : MonoBehaviour
{

    public Bubble[] bubblePrefabs;
    public int numToSpawn;
    public Transform spawnPoint;
    private Bubble[] bubbles;

    void Start()
    {
        bubbles = new Bubble[numToSpawn];
        for(int i = 0; i < numToSpawn; i++)
        {
            Bubble current = Instantiate(bubblePrefabs[Random.Range(0, bubblePrefabs.Length)]) as Bubble;

            Vector3 currentPos = Vector3.zero;

            currentPos.x += Random.Range(-3.0f, 3.0f);
            currentPos.y += Random.Range(-3.0f, 3.0f);
            currentPos.z += Random.Range(-3.0f, 3.0f);

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
