using UnityEngine;

public class balls_script : MonoBehaviour
{
    [SerializeField] float movespeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // This to = or - 1 for the x
        float y = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(x, y, 0f);
        transform.Translate(move * movespeed * Time.deltaTime);
    }
}
