using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_spawner : MonoBehaviour
{
    public GameObject bullet_prefab;     //생성한 아이템의 원본 프리팹
    public float spawn_rate_min = 0.5f;  //최소 생성주기
    public float spawn_rate_max = 3f;    //최대 생성주기

    Transform target;    //발사할 대상
    float spawn_rate;    //생성주기
    float time_after_spawn;  //최근 생성 시점에서 지난 시간
    // Start is called before the first frame update
    void Start()
    {
        //최근 생성 이후의 누적 시간을 0으로 초기화
        time_after_spawn = 0;
        //탄알 생성 간격을 spawn_rate_min 과 spawn_rate_max 사이에서 랜덤지정
        spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        //Player_controller 컴포넌트를 가지는 게임오브젝트를 찾아 조준 대사으로 설정
        target = FindObjectOfType<Player_controller>().transform;     
    }

    // Update is called once per frame
    void Update()
    {
        //time_after_spawn 갱신
        time_after_spawn += Time.deltaTime;

        //최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 같다면
        if (time_after_spawn > spawn_rate)
        {
            time_after_spawn = 0;

            GameObject bullet
                = Instantiate(bullet_prefab, transform.position, transform.rotation);

            bullet.transform.LookAt(target);

            spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        }

    }
}
