using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_01 : MonoBehaviour
{

    public int test_int;     //정수타임을 선언할때, 
    public float test_float;
    public bool test_bool;
    public string test_string;



    public int[] test_array_int = new int[2];      //int타입의 벼열 변수 선언 방법

    // Start is called before the first frame update
    void Start()
    {



        //test_array_int[0] = 1;           //배열 0번째 인덱스에 1의 값을 할당
        //test_int = test_array_int[0];    //배열 0번째 인덱스에 있는 1의 값을 test_int에 할당
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
