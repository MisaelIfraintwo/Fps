using UnityEngine;

public class enemystats : MonoBehaviour
{
    public float life;
    public void Da�otake(float da�o) {

        life -= da�o;
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
