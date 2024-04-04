using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening; //import

public class Player : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] float changeTime;
    [SerializeField] int jumpSpeed;
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

    private void Update()
    {
        transform.localPosition += transform.forward * playerSpeed * Time.deltaTime;
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
            velocity.y = jumpSpeed;
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

    

    private void OnTriggerEnter( Collider collision )
    {
        if ( ( leftMoveCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            leftMove = true;
        }
        if ( ( rightMoveCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            rightMove = true;
        }
        if ( ( jumpCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            jump = true;
        }
        if ( ( leftTurnCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            leftTurn = true;
        }
        if ( ( rightTurnCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            rightTurn = true;
        }
        if ( ( leftTurnJumpCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            leftTurnJump = true;
        }
        if ( ( rightTurnJumpCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            rightTurnJump = true;
        }        
    }
    private void OnTriggerExit( Collider collision )
    {
        if ( ( leftMoveCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            leftMove = false;
        }
        if ( ( rightMoveCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            rightMove = false;
        }
        if ( ( jumpCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            jump = false;
        }
        if ( ( leftTurnCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            leftTurn = false;
        }
        if ( ( leftTurnJumpCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            leftTurnJump = false;
        }
        if ( ( rightTurnJumpCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            rightTurnJump = false;
        }
        if ( ( rightTurnCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            rightTurn = false;
        }
    }
}
