using UnityEngine;
using System.Collections;

public class BubbleManager : MonoBehaviour
{

    public Bubble[] bubbles;

    void Update()
    {
        for(int i = 0; i < bubbles.Length; i++)
        {
            bubbles[i].Grow();
            bubbles[i].Rotate();
        }
    }
}
