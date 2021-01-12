using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Vector2 SPEED = new Vector2(0.05f, 0.05f);
    [SerializeField] float MAX_X_SPEED = 3f;
    [SerializeField] float MAX_Y_SPEED = 3f;

    public GameObject Goal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Vector3 Speed = new Vector2(0.1f, 0.1f);

    // Update is called once per frame
    private void Update()
    {
        //移動
        //Move();
        
        
    }

    private void FixedUpdate()
    {
        Move();
    }


    /*private void OnTriggerEnter(Collider other)
    {
        if (other.name == Goal.name)
        {
            SceneManager.LoadScene("Title");
        }
    }*/

    private void OnCollision2D(Collider other)
    {
        Debug.Log("Enter 2d");
        if (other.name == Goal.name)
        {
            Debug.Log("Enter load");

            SceneManager.LoadScene("Title");
        }
    }



    //移動関数
    void Move()
    {
        /*

       // 現在位置をPositionに代入

        Vector2 Position = transform.position;

        // 左キーを押し続けていたら

        

        Rigidbody2D rb = this.transform.GetComponent<Rigidbody2D>();


        if (Input.GetKey("left"))
        {
            Vector3 force = new Vector3(-3.0f, 0.0f, 0.0f);

            rb.AddForce(force);
            

        }
        else if (Input.GetKey("right"))  //右キーを押し続けていたら
        {
            Vector3 force = new Vector3(3.0f, 0.0f, 0.0f);

            // 速度が0.1以下なら力を加える
           
                rb.AddForce(force); // 力を加える
            
            

            if (Input.GetKeyUp("right"))
            {
                
            }

        }


        if (Input.GetKey("up"))  //上キーを押し続けていたら
        {
            Vector3 force = new Vector3(0.0f, 3.0f, 0.0f);

           
                rb.AddForce(force); // 力を加える
            
           
            
        }
        else if (Input.GetKey("down"))  //下キーを押し続けていたら
        {
            Vector3 force = new Vector3(0.0f, -3.0f, 0.0f);

           
                rb.AddForce(force); // 力を加える
            
            
        }

        Vector2 vec = rb.velocity;

        if(Mathf.Abs(rb.velocity.x) > MAX_X_SPEED)
        {
            vec.x = Mathf.Sign(rb.velocity.x) * MAX_X_SPEED;
        }

        if (Mathf.Abs(rb.velocity.y) > MAX_Y_SPEED)
        {
            vec.y = Mathf.Sign(rb.velocity.y) * MAX_Y_SPEED;
        }

        rb.velocity = vec;

        //rb.velocity = new vector3(-30.0f, 0.0f,0.0f);





      //transform.position = Position;









        
*/

        
        
            // 現在位置をPositionに代入
            Vector2 Position = transform.position;
            // 左キーを押し続けていたら
            if (Input.GetKey("left"))
            {
                // 代入したPositionに対して加算減算を行う
                Position.x -= SPEED.x;
            }
            else if (Input.GetKey("right"))
            { // 右キーを押し続けていたら
              // 代入したPositionに対して加算減算を行う
                Position.x += SPEED.x;
            }
            else if (Input.GetKey("up"))
            { // 上キーを押し続けていたら
              // 代入したPositionに対して加算減算を行う
                Position.y += SPEED.y;
            }
            else if (Input.GetKey("down"))
            { // 下キーを押し続けていたら
              // 代入したPositionに対して加算減算を行う
                Position.y -= SPEED.y;
            }
            // 現在の位置に加算減算を行ったPositionを代入する
            transform.position = Position;
        
    }
    
   

}

/*
 * 
 * */
