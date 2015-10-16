using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {
    
    private float capacity = 3.0f; // Largest bubble can be before it pops
    private float inflation = 1.0f; // Current scale
    private float step = 0.2f; // Amount to increment by
	
    void Start()
    {
        transform.localScale *= inflation;
    }

	void Update () {
        if(Input.GetKeyDown(KeyCode.G))
        {
            Grow();
        }
	}

    public void Grow()
    {
        inflation += step;
        transform.localScale *= inflation;
        if(inflation >= capacity)
        {
            Pop();
        }
    }

    public void Pop()
    {
        Destroy(this.gameObject);
    }
}
