using UnityEngine;

public class Bulllet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
        bulletRigidBody.linearVelocity = transform.forward * speed;
        
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }

}
