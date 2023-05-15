using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; //이동속도


    void Update() //게임 오브젝트를 일정 속도로 왼쪽으로 평행이동하는 처리
    {
        //초당 speed의 속도로 왼쪽으로 평행이동
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
