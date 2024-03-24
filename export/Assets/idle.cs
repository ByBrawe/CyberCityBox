using UnityEngine;

public class idle : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Karakterin hareket giriþi yoksa
        if (Input.GetKey(KeyCode.W))
        {
            // Animator Controller'ýn "isIdle" parametresini true olarak ayarla
            animator.SetBool("isRunning", true);
        }
        else
        {
            // Karakter hareket ediyorsa, "isIdle" parametresini false yap
            animator.SetBool("isRunning", false);
        }
    }
}
