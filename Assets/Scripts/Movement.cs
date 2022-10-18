using UnityEngine;

public class Movement : MonoBehaviour
{
   private Rigidbody2D body;
   [SerializeField] 
   public float speed;
   public float jumpPower;
    
   [SerializeField] private LayerMask mask;
   [SerializeField] private float distance;


   private void Awake()
   {
	 body = GetComponent<Rigidbody2D>();
   }


   private void Update()
   {
	   body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
	   

        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, distance, mask);

        // If it hits something...
        if (hit.collider != null && Input.GetKey(KeyCode.Space))
        {

            // Apply the force to the rigidbody.
           body.AddForce(Vector3.up * jumpPower);
        }
   }
    void FixedUpdate()
    {
        // Cast a ray straight down.
    }
}
