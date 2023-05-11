using UnityEngine;

//PlayerController�� �÷��̾� ĳ���ͷμ� Player ���� ������Ʈ�� ������
public class PlayerController : MonoBehaviour
{
    public AudioClip deathClip; // ��� �� ����� ����� Ŭ��
    public float jumpForce = 700f; // ���� ��
    private int jumpConunt = 0; // ���� ���� Ƚ��
    private bool isGrounded = false; // �ٴڿ� ��Ҵ��� ��Ÿ��
    private bool isDead = false; // �������

    private Rigidbody2D playerRigidbody; // ����� ������ٵ�  ������Ʈ
    private Animator animator; // ����� �ִϸ����� ������Ʈ
    private AudioSource playerAudio; // ����� ����� �ҽ� ������Ʈ
    
    private void Start() //�ʱ�ȭ
    {
        // ���� ������Ʈ�κ��� ����� ������Ʈ���� ������ ������ �Ҵ�
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // ����� �Է��� �����ϰ� �����ϴ� ó��
    }

    private void Die()
    {
        // ��� ó��
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
      //Ʈ���� �ݶ��̴��� ���� ��ֹ����� �浹�� ����  
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �ٴڿ� ������� �����ϴ� ó��
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // �ٴڿ��� ������� �����ϴ� ó��
    }
}