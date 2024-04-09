using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening; //import

public class Player : MonoBehaviour
{
    [SerializeField] public float playerSpeed;
    public float additionalMoveSpeed;
    [SerializeField] float changeTime;
    [SerializeField] public int jumpSpeed;
    public float additionalJumpSpeed;
    [SerializeField] Rigidbody rigid;
    [SerializeField] Transform trans;

    [Header("Judgment")]
    [SerializeField] LayerMask leftTurnCheck;
    [SerializeField] LayerMask leftMoveCheck;
    [SerializeField] LayerMask rightTurnCheck;
    [SerializeField] LayerMask rightMoveCheck;
    [SerializeField] LayerMask jumpCheck;
    [SerializeField] LayerMask leftTurnJumpCheck;
    [SerializeField] LayerMask rightTurnJumpCheck;
    [SerializeField] LayerMask damageCheck;
    
    private bool leftTurn;
    private bool leftMove;
    private bool rightTurn;
    private bool rightMove;
    private bool leftTurnJump;
    private bool rightTurnJump;
    private bool jump;    

    [Header("Move")]
    private bool isActionInProgress = false;
    [SerializeField] float actionCoolTime;

    //[Header("Sound")]
    [SerializeField] 


    private void Update()
    {
        transform.localPosition += transform.forward * (playerSpeed + additionalMoveSpeed ) * Time.deltaTime;
    }

    private void Action()
    {
        if ( isActionInProgress )
            return; // 이미 동작 중이면 무시

        isActionInProgress = true;
        Vector3 currentPosition = trans.position;

        if ( leftTurn == true )
        {
            Debug.Log("왼쪽턴");
            trans.Rotate(0f, -90f, 0f, Space.Self);
        }
        else if ( rightTurn == true )
        {
            Debug.Log("오른쪽턴");
            trans.Rotate(0f, +90f, 0f, Space.Self);
        }
        else if ( leftMove == true )
        {
            Debug.Log("왼쪽이동");
            transform.DOMove(currentPosition - trans.right + trans.forward * 0.3f, 0.15f, false);

        }
        else if ( rightMove == true )
        {
            Debug.Log("오른쪽이동");
            transform.DOMove(currentPosition + trans.right + trans.forward * 0.3f, 0.15f, false);

        }
        else if ( leftTurnJump == true )
        {
            Debug.Log("왼쪽으로점프");
            trans.Rotate(0f, -90f, 0f, Space.Self);
            Vector2 velocity = rigid.velocity;
            velocity.y = jumpSpeed;
            rigid.velocity = velocity;
        }
        else if ( rightTurnJump == true )
        {
            Debug.Log("오른쪽으로점프");
            trans.Rotate(0f, +90f, 0f, Space.Self);
            Vector2 velocity = rigid.velocity;
            velocity.y = jumpSpeed;
            rigid.velocity = velocity;
        }
        else if ( jump == true )
        {
            Debug.Log("점프");
            Vector2 velocity = rigid.velocity;
            velocity.y = jumpSpeed+ additionalJumpSpeed;
            rigid.velocity = velocity;
        }
        
        StartCoroutine(ResetActionCooldown());
    }

    private void OnAction( InputValue value )
    {
        Action();
    }

    private IEnumerator ResetActionCooldown()
    {
        yield return new WaitForSeconds(actionCoolTime);
        isActionInProgress = false;
    }

    private int leftMoveCount;
    private int rightMoveCount;
    private int leftTurnCount;
    private int rightTrunCount;
    private int jumpCount;
    private int leftTurnJumpCount;
    private int rightTurnJumpCount;



    private void OnTriggerEnter( Collider collision )
    {
        if ( leftMoveCheck.Contain(collision.gameObject.layer) )
        {
            leftMove = true;
            leftMoveCount++;
            leftMove = leftMoveCount > 0;
        }

        if ( rightMoveCheck.Contain(collision.gameObject.layer) )
        {
            rightMove = true;
            rightMoveCount++;
            rightMove = rightMoveCount > 0;
        }

        if ( leftTurnCheck.Contain(collision.gameObject.layer) )
        {
            leftTurn = true;
            leftTurnCount++;
            leftTurn = leftTurnCount > 0;
        }

        if ( rightTurnCheck.Contain(collision.gameObject.layer) )
        {
            rightTurn = true;
            rightTrunCount++;
            rightTurn = rightTrunCount > 0;
        }
        
        if ( jumpCheck.Contain(collision.gameObject.layer) )
        {
            jump = true;
            jumpCount++;
            jump = jumpCount > 0;
        }

        if ( leftTurnJumpCheck.Contain(collision.gameObject.layer) )
        {
            leftTurnJump = true;
            leftTurnJumpCount++;
            leftTurnJump = leftTurnJumpCount > 0;
        }

        if ( rightTurnJumpCheck.Contain(collision.gameObject.layer) )
        {
            rightTurnJump = true;
            rightTurnJumpCount++;
            rightTurnJump = rightTurnJumpCount > 0;
        }
    }
    private void OnTriggerExit( Collider collision )
    {
        if ( leftMoveCheck.Contain(collision.gameObject.layer) )
        {
            leftMove = false;
            leftMoveCount--;
            leftMove = leftMoveCount > 0;
        }

        if ( rightMoveCheck.Contain(collision.gameObject.layer) )
        {
            rightMove = false;
            rightMoveCount--;
            rightMove = rightMoveCount > 0;
        }

        if ( leftTurnCheck.Contain(collision.gameObject.layer) )
        {
            leftTurn = false;
            leftTurnCount--;
            leftTurn = leftTurnCount > 0;
        }

        if ( rightTurnCheck.Contain(collision.gameObject.layer) )
        {
            rightTurn = false;
            rightTrunCount--;
            rightTurn = rightTrunCount > 0;
        }

        if ( jumpCheck.Contain(collision.gameObject.layer) )
        {
            jump = false;
            jumpCount--;
            jump = jumpCount > 0;
        }

        if ( leftTurnJumpCheck.Contain(collision.gameObject.layer) )
        {
            leftTurnJump = false;
            leftTurnJumpCount--;
            leftTurnJump = leftTurnJumpCount > 0;
        }

        if ( rightTurnJumpCheck.Contain(collision.gameObject.layer) )
        {
            rightTurnJump = false;
            rightTurnJumpCount--;
            rightTurnJump = rightTurnJumpCount > 0;
        }
    }
}
