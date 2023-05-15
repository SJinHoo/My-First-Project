using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnityTransform : MonoBehaviour
{
    /************************************************************************
	 * Ʈ������ (Transform)
	 * 
	 * ���ӿ�����Ʈ�� ��ġ, ȸ��, ũ�⸦ �����ϴ� ������Ʈ
	 * ���ӿ�����Ʈ�� �θ�-�ڽ� ���¸� �����ϴ� ������Ʈ
	 * ���ӿ�����Ʈ�� �ݵ�� �ϳ��� Ʈ������ ������Ʈ�� ������ ������ �߰� & ������ �� ����
	 ************************************************************************/
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
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
        // transform.Translate�� �����϶��� ������ �ٶ󺸴� �������� �������� �� ����
        // Space.World ���� ������� Space.Self ������Ʈ ����

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
        // ���� �̿��� ȸ�� (���� �������� �ð�������� ȸ��)
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
        // ���Ϸ��� �̿��� ȸ��
        //transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        // x,y,z�� �̿��� ȸ��
        //transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }

    public void LookAt()
    {
        transform.LookAt(new Vector3(0, 0, 0));
    }
    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;

    }

    // <Quarternion & Euler>
    // Quarternion	: ����Ƽ�� ���ӿ�����Ʈ�� 3���� ������ �����ϰ� �̸� ���⿡�� �ٸ� ���������� ��� ȸ������ ����
    //				  �������� ȸ������ ������ ������ �߻����� ����
    // EulerAngle	: 3���� �������� ���������� ȸ����Ű�� ���
    //				  ������������ ������ ������ �߻��Ͽ� ȸ���� ��ġ�� ���� ���� �� ����
    // ������		: ���� �������� ������Ʈ�� �� ȸ�� ���� ��ġ�� ����

    // Quarternion�� ���� ȸ�������� ����ϴ� ���� ���������� �ʰ� �����ϱ� �����
    // ������ ��� ���ʹϾ� -> ���Ϸ����� -> �������� -> ������Ϸ����� -> ������ʹϾ� �� ���� ������ ��� ���ʹϾ��� �����
    private void Rotation()
    {
        transform.position = new Vector3(0, 0, 0);

        // Ʈ�������� ȸ������ Euler���� ǥ���� �ƴ� Quaternion�� �����
        transform.rotation = Quaternion.identity;

        // Euler������ Quaternion���� ��ȯ
        transform.rotation = Quaternion.Euler(0, 90, 0);
        // transform.rotation.ToEulerAngles();
    }



}
    

