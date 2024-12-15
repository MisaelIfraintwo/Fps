using UnityEngine;

public class disparo : MonoBehaviour
{
    public GameObject bala;
    public Transform shoot;
    public float fuerzaShoot;
    public float tiemPershoot;
    private float tiempoultDisp;
   
    public void Update()
    {
        if (Input.GetButtonDown("Fire1") && puedeshootear())
        {
            shootear(); 
            }
    }
    bool puedeshootear()
    {
        return Time.time >= tiempoultDisp + tiemPershoot;
    }

    private void shootear()
    {
        GameObject Bala = Instantiate(bala, shoot.position, shoot.rotation);

        Rigidbody rb = Bala.GetComponent<Rigidbody>();

        rb.AddForce(shoot.forward * fuerzaShoot, ForceMode.Impulse);

        tiempoultDisp = Time.time;
    }
}
