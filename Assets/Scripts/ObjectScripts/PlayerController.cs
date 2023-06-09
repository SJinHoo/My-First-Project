using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    private Vector3 moveDir;
    [SerializeField]
    public int moveSpeed;
    [SerializeField]
    public int JumpPower;
    [SerializeField]
    public int rotateSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Rotate();
        Move();
        
    }

    private void Move()
    {
        //transform.position += moveDir *moveSpeed* Time.deltaTime;
        // x : 1m/s
        transform.Translate(moveDir * moveSpeed * Time.deltaTime,Space.World);
        // transform.Translate로 움직일때는 무조건 바라보는 방향으로 움직여줄 수 있음
        // Space.World 게임 월드기준 Space.Self 오브젝트 기준
        
    }
    private void Jump()
    {
        rb.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
    }
    private void OnJump(InputValue value)
    {
        Jump();
    }
    public void Rotate()
    {
        // 축을 이용한 회전 (축을 기준으로 시계방향으로 회전)
		transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime,Space.World);
		// 오일러를 이용한 회전
		//transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
		// x,y,z를 이용한 회전
		//transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }

    public void LookAt()
    {
        transform.LookAt(new Vector3(0,0,0));
    }
    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;

    }

    // <Quarternion & Euler>
    // Quarternion	: 유니티의 게임오브젝트의 3차원 방향을 저장하고 이를 방향에서 다른 방향으로의 상대 회전으로 정의
    //				  기하학적 회전으로 짐벌락 현상이 발생하지 않음
    // EulerAngle	: 3축을 기준으로 각도법으로 회전시키는 방법
    //				  직관적이지만 짐벌락 현상이 발생하여 회전이 겹치는 축이 생길 수 있음
    // 짐벌락		: 같은 방향으로 오브젝트의 두 회전 축이 겹치는 현상

    // Quarternion을 통해 회전각도를 계산하는 것은 직관적이지 않고 이해하기 어려움
    // 보통의 경우 쿼터니언 -> 오일러각도 -> 연산진행 -> 결과오일러각도 -> 결과쿼터니언 과 같이 연산의 결과 쿼터니언을 사용함
    private void Rotation()
    {
        transform.position = new Vector3(0, 0, 0);
        
        // 트랜스폼의 회전값은 Euler각도 표현이 아닌 Quaternion을 사용함
        transform.rotation = Quaternion.identity;

        // Euler각도를 Quaternion으로 변환
        transform.rotation = Quaternion.Euler(0, 90, 0);
        // transform.rotation.ToEulerAngles();
    }



}
