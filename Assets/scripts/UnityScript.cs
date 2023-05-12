using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityScript : MonoBehaviour
{
    /************************************************************************
      * ������Ʈ (Component)
      * 
      * Ư���� ����� ������ �� �ֵ��� ������ ���� ����� ����
      * ���ӿ�����Ʈ�� �۵��� ������ ��ǰ
      * ���ӿ�����Ʈ�� �߰�, �����ϴ� ����� ������ ��ǰ
      ************************************************************************/

    /************************************************************************
	 * MonoBehaviour
	 * 
	 * ������Ʈ�� �⺻Ŭ������ �ϴ� Ŭ������ ����Ƽ ��ũ��Ʈ�� �Ļ��Ǵ� �⺻ Ŭ����
	 * ���� ������Ʈ�� ��ũ��Ʈ�� ������Ʈ�μ� ������ �� �ִ� ������ ����
	 * ��ũ��Ʈ ����ȭ ���, ����Ƽ�޽��� �̺�Ʈ�� �޴� ���, �ڷ�ƾ ����� ������
	 ***********************************************************************/

    // <��ũ��Ʈ ����ȭ ���>
    // �ν����� â���� ������Ʈ�� �ɹ����� ���� Ȯ���ϰų� �����ϴ� ���
    // ������Ʈ�� ������ �����͸� Ȯ���ϰų� ����
    // ������Ʈ�� �������� �����͸� �巡�� �� ��� ������� ����

    // <�ν�����â ����ȭ�� ������ �ڷ���>
    [Header("C# Type")]
    public bool boolValue;
    public int intValue;
    public float floatValue;
    public string stringValue;
    // �� �� �⺻ �ڷ���

    // �⺻ �ڷ����� �����ڷᱸ��
    public int[] array;
    public List<int> list;

    [Header("Unity Type")]
    public Vector3 vector3;     
    public Color color;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;

    [Header("Unity GameObject")]
    public GameObject obj;
    public Rigidbody rb;

    [Header("Unity Component")]
    public new Transform transform;
    public new Rigidbody rigidbody;
    public new Collider collider;

    
    [Header("Unity Event")]
    public UnityEvent OnEvent;

    // inspector â�� ǥ�õ����ʰ� ��ũ��Ʈâ���� ����� �ϰ������ private�� �ٲ���

    // < ��Ʈ�� ��Ʈ>
    // Ŭ����, ������Ƽ �Ǵ� �Լ� ���� ����Ͽ� Ư���� ������ ��Ÿ�� �� �ִ� ��Ŀ

    [Space(30)]

    
    [Header("Unity Attribute")]
    [SerializeField]        // private ������ inspector â���� ��Ʈ�� �ϰ� ���� ���
    private int privateValue;
    [HideInInspector]       // public ������ inspector â���� ����� ���� ��� (�ڵ�� ��Ʈ�� �ϰ� ���� ���)
    public int publicValue;

    [Range(0, 10)]          // range �����̵� ����
    public float rangeValue;

    [TextArea(3, 5)]        // 
    public string textField;
}
