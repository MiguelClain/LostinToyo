using UnityEngine;
 
 public class PlayerAI : MonoBehaviour
 {
     private int Playerlevel;
     private float speed = 100f;
     private Vector2 playerpos;
     private Rigidbody2D player_rb;
 
     void Start()
     {
         player_rb = GetComponent<Rigidbody2D>();
     }
     
     public void FixedUpdate()
     {
         player_rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.fixedDeltaTime, 
                                          Input.GetAxisRaw("Vertical") * speed * Time.fixedDeltaTime);
     }
 
     void OnCollisionEnter2D(Collision2D collision)
     {
         player_rb.velocity = Vector2.zero;
     }
 }