using UnityEngine;

public class enemystats : MonoBehaviour
{
    public float life;
    public void Dañotake(float daño) {

        life -= daño;
        if (life <= 0 )
        {
            Morir();
        }
    
    }
    private void Morir() 
    {
        Destroy(gameObject);
    }
}
