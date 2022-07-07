using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 5;
    public float xrange = 2;
    public float upperyrange = 3.6f;
    public float loweryrange = -2.2f;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject projectile;

    private float timeBtwShots;
    public float startTimeBtwShots;


    private Rigidbody2D playerRb;

    public GameObject DefaultProjectilePrefab;
    //public GameObject DefaultChargedProjectilePrefad;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(1);
        }

        horizontalInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);

        if (transform.position.x > xrange)
        {
            transform.position = new Vector2(xrange, transform.position.y);
        }

        if (transform.position.x < -xrange)
        {
            transform.position = new Vector2(-xrange, transform.position.y);
        }

        //playerRb.AddForce(Vector2.right * horizontalInput * horizontalInput);

        verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);

        //if (transform.position.y > upperyrange)
        {
            //transform.position = new Vector2(xrange,  upperyrange);
        }

        //if (transform.position.y < loweryrange)
        {
           // transform.position = new Vector2(-xrange, loweryrange);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timeBtwShots <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timeBtwShots = startTimeBtwShots;

            }
            else
            {
                timeBtwShots -= Time.deltaTime;
                
            }
            //Instantiate(DefaultProjectilePrefab, transform.position, DefaultProjectilePrefab.transform.rotation);
            
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            if (timeBtwShots <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timeBtwShots = startTimeBtwShots;

            }
            else
            {
                timeBtwShots -= Time.deltaTime;

            }
            //Instantiate(DefaultProjectilePrefab, transform.position, DefaultProjectilePrefab.transform.rotation);

        }



    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

}






//Orty and Mick's
//Gas Up//

   //////////////////////
  ///                ///
 ///  Orty and Mik  ///
///                ///
/////////////////////

//else
//if (Input.GetKey(KeyCode.Space) && Time.time > 3.0f)
//{
    // Instantiate(DefaultChargedProjectilePrefad, transform.position, DefaultChargedProjectilePrefad.transform.rotation);
//}


//Vector3 mousePos = Input.mousePosition;
//mousePos.z = 0;

//Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
//mousePos.x = mousePos.x - objectPos.x;
//mousePos.y = mousePos.y - objectPos.y;

//float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
//transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));