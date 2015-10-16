using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {
    
    public float capacity = 3.0f; // Largest bubble can be before it pops
    public float minSize = 1.0f; // Current scale
    public float inflation = 1.0f; // Current scale
    public float step = 1.0f; // Amount to increment by
    private float xRot;
    private float yRot;
    private float zRot;
	
    void Start()
    {
        transform.localScale *= inflation;

        xRot = Random.Range(-2.0f, 2.0f);
        yRot = Random.Range(-2.0f, 2.0f);
        zRot = Random.Range(-2.0f, 2.0f);

        Debug.Log(xRot);
        Debug.Log(yRot);
        Debug.Log(zRot);
    }

    public void Grow()
    {
        transform.localScale.Set(transform.localScale.x + step, transform.localScale.y + step, transform.localScale.z + step);
        if(inflation >= capacity)
        {
            step = -step;
        }
        if(inflation <= minSize)
        {
            step = +step;
        }
    }

    public void Rotate()
    {
        transform.Rotate(xRot, yRot, zRot);
    }
}
