using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VassicVariables : MonoBehaviour
{
    public int gold = 0;       //정수형
    public float Hp = 100.0f; //실수형 (소수점이 있는 숫자, 끝에 "f" 필수)
    public string playerName = "홍길동"; //문자열 (문자의 집합)
    private bool isAlive = true; //논리형 (참/거짓을 나타냄) true/false

    // Start is called before the first frame update
    void Start()
    {

        //Debug.Log("게임시작");       //유니티 디버그에 메세지를 출력
        if (gold > 50) //만약 gold가 50보다 크다면
        {
            Debug.Log("아이템을 구매할 수 있습니다");    //메시지 출력

        }
        else if (gold > 25)
        {
            Debug.Log("일부 아이템을 구매할수 있습니다"); //메시지 출력
        }

        else
        {
            Debug.Log("돈이 부족합니다"); //메시지 출력

        }
    
    
    
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Debug.Log("게임 진행중"); //유니티 디버그에 메세지를 출력
            gold = gold + 10;
        Debug.Log("현재 골드 : " + gold);
    }
}
