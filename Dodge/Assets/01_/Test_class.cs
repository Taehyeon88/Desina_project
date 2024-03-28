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
        taehyeon = new Human();   //Human타입의 객체를 만들어줬다(인스턴스화)
        taehyeon.age = 25;        //사람의 나이를 정해줌
        taehyeon.name= "태현";   //사람의 이름을 정해줌
        Debug.Log("이름 : "+ taehyeon.name);
        Debug.Log("나이 :" + taehyeon.age);
        taehyeon_01 = taehyeon;
        Debug.Log("이름 : " + taehyeon_01.name);
        Debug.Log("나이 :" + taehyeon_01.age);
        taehyeon_01.age = 15;                  //taehyeon_01의 age(나이)를 15로 바뀜
        Debug.Log("이름 : " + taehyeon.name);  //클래스가 창조타입이라 taehyeon_01의
        Debug.Log("나이 :" + taehyeon_01.age); /*age(나이)를 바꿔도 taehyeon변수 안에 있는 age라는 값이 바뀜*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Human
{
    public string name;      //private는 Human 클래스 내부에서만 접근이 가능하다
    public int age;          //public은 Human 클래스 외부에서도 접근이 가능하다   
    protected string test_protected;
    void Test_method()
    {
        name = "이름";
        age = 25;
    }
}
public class Test_Human2 : Human
{

    void Test_method()
    {
        test_protected = "테스트용 문자열";  //protected로 선언되어 있어서 외부에선 접근이 불가능 하지만 상속받은 클래스에선 접근이 가능하다 
    }
}
