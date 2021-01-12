using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
<<<<<<< HEAD
    public Vector2 SPEED = new Vector2(0.05f, 0.05f);
    [SerializeField] float MAX_X_SPEED = 3f;
    [SerializeField] float MAX_Y_SPEED = 3f;

    public GameObject Goal;


    // Start is called before the first frame update
    void Start()
=======
    public Vector2 Speed = new Vector2(0.05f, 0.05f);
    private float MoveSpeed;
    private float MoveMaxSpeed;
    protected Vector2 _vtargetPos;
    private bool _bMoveOK;
    private bool _bfollowdistance;
    float timer = 0;
    private Vector2 oldTargetPos;
    enum MoveState
>>>>>>> 0ff294b17a83e1cc3e637d20a8ae1339f2418361
    {
        default_free = 0,
        follow_down_delay = 1,
        follow_delay = 2,
        follow_up_check = 3,
        follow_overlap = 4,
    };
    MoveState state = MoveState.default_free;

<<<<<<< HEAD
    public Vector3 Speed = new Vector2(0.1f, 0.1f);
=======
    //=======================================
    // 受け渡し
    //=======================================
    //read->CodeLine.cs
    public int GetPlayerState()
    {
        return (int)state;
    }
    //write->GameData.cs
    public float GSSpeed
    {
        get { return MoveSpeed; }
        set { MoveSpeed = value; }
    }
    public float GSMaxSpeed
    {
        get { return MoveMaxSpeed; }
        set { MoveMaxSpeed = value; }
    }
    //プレイヤーが操作できる状態にするかどうか
    public bool GSPlayerMove
    {
        get { return _bMoveOK; }
        set { _bMoveOK = value; }
    }
    //マウスターゲット位置
    public bool GetMouseTargetPosbecouse()
    {
        var pos1 = (oldTargetPos - (Vector2)transform.position);
        var pos2 = (_vtargetPos - (Vector2)transform.position);
        return (pos1.normalized == pos2.normalized) ? true : false;
    }
    
    //=======================================
    // 処理
    //=======================================
>>>>>>> 0ff294b17a83e1cc3e637d20a8ae1339f2418361

    void Start()
    {
        //コードの位置調整
        transform.GetChild(0).position = transform.position + new Vector3(-transform.GetComponent<SpriteRenderer>().bounds.extents.x, 0) * 0.9f;
        _vtargetPos = transform.position;
    }
    private void Update()
    {
<<<<<<< HEAD
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



=======
        if (_bMoveOK)
        {
            //移動
            //Move();
            MouseInputterCheck();
            DelayMover();
        }
    }

    //使用してません
>>>>>>> 0ff294b17a83e1cc3e637d20a8ae1339f2418361
    //移動関数
    void Move()
    {
        /*

<<<<<<< HEAD
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
=======
        // 現在位置をPositionに代入
        Vector2 Position = transform.position;

        // 左キーを押し続けていたら
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 代入したPositionに対して加算減算を行う
            Position.x -= Speed.x;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Position.x += Speed.x;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Position.y += Speed.y;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Position.y -= Speed.y;
        }
        // 現在の位置にPositionを代入する
        transform.position = Position;
    }

    //--------------------------------------------------
    // マウス状態チェック
    //--------------------------------------------------
    void MouseInputterCheck()
    {
        if (Input.GetMouseButtonDown(0)) state = MoveState.follow_down_delay;
        if (Input.GetMouseButtonUp(0)) state = MoveState.follow_up_check;
    }

    //--------------------------------------------------
    // マウス位置取得(screenToWorldPointPosition)
    //--------------------------------------------------
    Vector2 GetMousePosition()
    {
        Vector3 position = Input.mousePosition;
        // Z軸修正
        position.z = Camera.main.transform.position.z;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        return Camera.main.ScreenToWorldPoint(position);
    }

    //--------------------------------------------------
    // 一定速度でマウスを追尾・マウス放すと遅れて停止
    //--------------------------------------------------
    void DelayMover()
    {
        switch(state)
        {
            case MoveState.default_free:break;
            case MoveState.follow_down_delay:
                oldTargetPos = _vtargetPos;
                _vtargetPos = GetMousePosition();//Vector3でマウス位置座標を取得する
                transform.position = Vector2.MoveTowards(transform.position, _vtargetPos, Time.deltaTime * MoveSpeed);
                state = MoveState.follow_delay;
                break;
            case MoveState.follow_delay:
                oldTargetPos = _vtargetPos;
                _vtargetPos = GetMousePosition();//Vector3でマウス位置座標を取得する
                transform.position = Vector2.MoveTowards(transform.position, _vtargetPos, Time.deltaTime * MoveSpeed);
                break;
            case MoveState.follow_up_check:
                oldTargetPos = transform.position;
                Vector2 pos = ((Vector2)transform.position - _vtargetPos);
                _bfollowdistance = (pos.magnitude < MoveSpeed) ? true : false;
                MovePosition();
                state = MoveState.follow_overlap;
                timer += Time.deltaTime;
                break;
            case MoveState.follow_overlap:
                oldTargetPos = _vtargetPos;
                timer += Time.deltaTime;
                MovePosition();
                if (timer >= 1)
                {
                    state = MoveState.default_free;
                    timer = 0;
                }
                break;
        }
    }
    void MovePosition()
    {
        if (_bfollowdistance)
            transform.position = Vector2.Lerp(transform.position, _vtargetPos, Time.deltaTime * MoveSpeed);
        else
            transform.position = Vector2.MoveTowards(transform.position, _vtargetPos, Time.deltaTime * MoveSpeed);
    }

    //--------------------------------------------------
    // 当たり判定
    //--------------------------------------------------
    void OnColliderEnter(Collision collision)
    {
        if(collision.gameObject.tag == "outlet")//＜－コンセント英訳
        {
            Debug.Log("hit");
        }
    }
}
>>>>>>> 0ff294b17a83e1cc3e637d20a8ae1339f2418361
