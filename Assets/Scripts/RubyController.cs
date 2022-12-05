using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float speed = 3.0f;

    public int maxHealth = 5;
    int currentHealth;

    public int health{ get { return currentHealth;}}

    Rigidbody2D rigidbody2D;
   float horizontal;
   float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

     


    // Update is called once per frame
    void Update()
    {
         horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");

        Debug.Log(horizontal);
        
        
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        position.x = position.x + 5.0f * horizontal * Time.deltaTime;
        position.y = position.y + 5.0f * vertical * Time.deltaTime;
        
        rigidbody2D.MovePosition(position);
    } 
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }

} 
