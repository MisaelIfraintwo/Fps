using UnityEngine;

public class balad : MonoBehaviour
{
    public float duration;
    
    void Start()
    {
        Destroy(gameObject, duration);
    }

    
    
}
