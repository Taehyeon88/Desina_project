using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_class : MonoBehaviour
{
    public Human taehyeon;
    public Human taehyeon_01;
    // Start is called before the first frame update
    void Start()
    {
        taehyeon = new Human();   //HumanŸ���� ��ü�� ��������(�ν��Ͻ�ȭ)
        taehyeon.age = 25;        //����� ���̸� ������
        taehyeon.name= "����";   //����� �̸��� ������
        Debug.Log("�̸� : "+ taehyeon.name);
        Debug.Log("���� :" + taehyeon.age);
        taehyeon_01 = taehyeon;
        Debug.Log("�̸� : " + taehyeon_01.name);
        Debug.Log("���� :" + taehyeon_01.age);
        taehyeon_01.age = 15;                  //taehyeon_01�� age(����)�� 15�� �ٲ�
        Debug.Log("�̸� : " + taehyeon.name);  //Ŭ������ â��Ÿ���̶� taehyeon_01��
        Debug.Log("���� :" + taehyeon_01.age); /*age(����)�� �ٲ㵵 taehyeon���� �ȿ� �ִ� age��� ���� �ٲ�*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Human
{
    public string name;      //private�� Human Ŭ���� ���ο����� ������ �����ϴ�
    public int age;          //public�� Human Ŭ���� �ܺο����� ������ �����ϴ�   
    protected string test_protected;
    void Test_method()
    {
        name = "�̸�";
        age = 25;
    }
}
public class Test_Human2 : Human
{

    void Test_method()
    {
        test_protected = "�׽�Ʈ�� ���ڿ�";  //protected�� ����Ǿ� �־ �ܺο��� ������ �Ұ��� ������ ��ӹ��� Ŭ�������� ������ �����ϴ� 
    }
}
