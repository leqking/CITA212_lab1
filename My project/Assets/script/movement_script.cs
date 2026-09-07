using UnityEngine;

public class balls_script : MonoBehaviour
{
    [SerializeField] float movespeed = 5f;
    [SerializeField] float rotatespeed = 120f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    //Rotations


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, rotatespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, -rotatespeed * Time.deltaTime);

        }
        float x = Input.GetAxis("Horizontal"); // This to = or - 1 for the x
        float y = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(x, y, 0f);
       // transform.Rotate(0f, 0.4f, 0f);
        transform.Translate(move * movespeed * Time.deltaTime);
       
    }
    
   void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Happened with " + collision.gameObject.name);
        if (collision.collider.CompareTag("test"))
        {
            Debug.Log("Hitting Floor");
        }
    }

}
