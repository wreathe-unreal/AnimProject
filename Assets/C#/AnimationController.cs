using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public float AccelerationSpeed = 0.1f;
    public float DecelerationSpeed = 0.5f;
    private float Velocity = 0.0f;
    private Animator AnimatorComponent;
    // Start is called before the first frame update
    private void Start()
    {
        AnimatorComponent = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
    //     bool bIsWalking = AnimatorComponent.GetBool("bIsWalking");
    //     bool bIsRunning = AnimatorComponent.GetBool("bIsRunning");
        bool bForwardInput = Input.GetKey("w");
        bool bRunInput = Input.GetKey("left shift");
    //     
    //     if (!bIsWalking && bForwardInput)
    //     {
    //         AnimatorComponent.SetBool("bIsWalking", true);
    //     }
    //     
    //     if(bIsWalking && !bForwardInput)
    //     {
    //         AnimatorComponent.SetBool("bIsWalking", false);
    //     }
    //
    //     if (!bIsRunning && bRunInput)
    //     {
    //         AnimatorComponent.SetBool("bIsRunning", true);
    //     }
    //
    //     if (bIsRunning && !bRunInput)
    //     {
    //         AnimatorComponent.SetBool("bIsRunning", false);
    //     }
    
        if (bForwardInput && Velocity < 1.0f)
        {
            Velocity += Time.deltaTime * AccelerationSpeed;
            
        }

        if (!bForwardInput && Velocity > 0.0f)
        {
            Velocity -= Time.deltaTime * DecelerationSpeed;
        }

        if (Velocity < 0.0f)
        {
            Velocity = 0.0f;
        }

        AnimatorComponent.SetFloat("Velocity", Velocity);
    }
}
