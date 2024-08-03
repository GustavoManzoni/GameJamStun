using UnityEngine;

public class Tiro : MonoBehaviour
{
    public Transform player; 
    public GameObject projectilePrefab;  
    public float orbitDistance = 1.0f;  
    public float orbitSpeed = 5.0f;  
    public float projectileSpeed = 10.0f;  
    public float cooldown;
    private float currentAngle = 0.0f;
    private GameObject Player;
    Animator anim;
    
    void Update()
    {
        Player = GameObject.FindWithTag("Player");
        anim = Player.GetComponent<Animator>();
        cooldown += Time.deltaTime;
        FollowMouse();
        if (Input.GetMouseButtonDown(0) && cooldown > 0.8f)
        {
            Shoot();
            cooldown = 0.0f;
            anim.SetTrigger("Atirando");
            Invoke("idleTrue", 0.30f);

        }
    }

    void FollowMouse()
    {
       
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


       
        Vector3 direction = mousePosition - player.position;
        float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

       
        currentAngle = Mathf.LerpAngle(currentAngle, targetAngle, Time.deltaTime * orbitSpeed);

      
        Vector3 offset = new Vector3(Mathf.Cos(currentAngle * Mathf.Deg2Rad), Mathf.Sin(currentAngle * Mathf.Deg2Rad), 0) * orbitDistance;
        transform.position = player.position + offset;

      
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, currentAngle - 90));
    }

    void Shoot()
    {
      
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);

        
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = transform.up * projectileSpeed; 
        }
        
    }
    public void idleTrue()
    {
        anim.SetBool("Idle", true);
        Invoke("IdleFalse", 0.4f);


    }
    public void IdleFalse()
    {

        anim.SetBool("Idle", false);

    }
   
}
