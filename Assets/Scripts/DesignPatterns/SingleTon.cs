using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    //========================================
	//##		������ ���� SingleTon		##
	//========================================
	/*
		�̱��� ���� :
		���� �� ���� Ŭ���� �ν��Ͻ����� ������ ����
		�̿� ���� �������� �������� ����

		���� :
		1. �������� ���� ������ �ν��Ͻ��� �ּҸ� ���� ����
		������ ���� �޸� ������ Ȱ�� (��������)
		2. ���������� Ȱ���Ͽ� ĸ��ȭ�� ����
		3. �������� ���ٱ����� �ܺο��� ������ �� ������ ����
		4. Instance �Ӽ��� ���� �ν��Ͻ��� ������ �� �ֵ��� ��
		5. instance ������ �� �ϳ��� �ֵ��� ����

		���� :
		1. �ϳ����� ����� �ֿ� Ŭ����, �������� ������ ��
		2. ������ �������� ������ �ʿ��� �۾��� ���� �������ٰ���
		3. �ν��Ͻ����� �̱����� ���Ͽ� �����͸� �����ϱ� ������

		���� :
		1. �̱����� �ʹ� ���� å���� �������� ��츦 �����ؾ���
		2. �̱����� ���߷� ���������� �������� �Ǵ� ���, ������ �ڵ� ���յ��� ������
		3. �̱����� �����͸� ������ ��� ������ ������ �����ؾ���
	*/

	// �������� ������ �ϰ� �� ��� �̱��� �������� ���� ���ش�.


public class SingleTon
{
    private static SingleTon instance;

    public static SingleTon Instance
    {
        get
        {
			// ���ο��� �ν��Ͻ��� ���°�� �ν��Ͻ��� ������ְ�
            if (instance == null)
                instance = new SingleTon();
			// �ִٸ� �ν��Ͻ��� �״�� �������ش�
            return instance;
        }
    }

	private SingleTon() { }	// �����ڸ� private���� ������ �ؼ� �ܺο��� new�� ���� ���� ���� ���� �� ���� ����
}

// �ܺο��� �̱����� �� ��� inventory ����
public class Player
{

	public void Test()
	{
		SingleTon inven1 = SingleTon.Instance;
		SingleTon inven2 = SingleTon.Instance;
		SingleTon inven3 = SingleTon.Instance;
		SingleTon inven4 = SingleTon.Instance;

		// error : SingleTon inven5 = new SingleTon();
		// �ܺο��� ���Ƿ� ���� ���ϰ� ���� �ϰ�
		// instance�� �ݵ�� �ϳ��� ���� �� �ֵ��� �����ϴ� ���� �ٷ� SingleTon ������ �����̴�
	}
}