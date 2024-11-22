using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody playerRigidBody;
    public float speed = 8f;

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3 (xSpeed, 0f, zSpeed);
        playerRigidBody.linearVelocity = newVelocity;

        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    playerRigidBody.AddForce(0f, 0f, speed);
        //}
        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    playerRigidBody.AddForce(0f, 0f, -speed);
        //}
        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    playerRigidBody.AddForce(speed, 0f, 0f);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    playerRigidBody.AddForce(-speed, 0f, 0f);
        //}
    }
    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindFirstObjectByType<GameManager>();
        gameManager.EndGame();
    }
}
