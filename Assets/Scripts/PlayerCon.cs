using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCon : MonoBehaviour
{
    public GameObject light;
    

    private float speed = 2.0f;

    private Vector3 vector;

    private Vector3 lightVector;
    
    /*private void OnMove(InputValue value)
    {
        var axis = value.Get<Vector2>();

        vector = new Vector3(axis.x, axis.y);
    }*/
    
    private void OnLightMove(InputValue value)
    {
        var axis = value.Get<Vector2>();

        lightVector=new Vector3(axis.x, axis.y);
    }
    /*
    public void OnMove(InputAction.CallbackContext context)
    {
        
    }
    */
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += vector * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
        }
    }
}
