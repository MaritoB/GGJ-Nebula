using UnityEngine;

public class BubbleHandler : MonoBehaviour
{
    
       [SerializeField]
    float BubbleMaxSize, BubbleMinSize;
    [SerializeField]
    float BubbleDecreaseRatio;
    [SerializeField]
    float BubbleIncreaseRatio;
    [SerializeField]
    float BubbleUpBaseSpeed, BubbleSideSpeed, BubbleMaxVelocity;
    [SerializeField]
    Transform BubbleSprite;

    [SerializeField]
    ParticleSystem PSBubble;
    [SerializeField]
    float StartSize;
    [SerializeField]
    float CurrentScale;
    Rigidbody2D rigidbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        CurrentScale = StartSize;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && CurrentScale < BubbleMaxSize)
        {
            CurrentScale +=BubbleIncreaseRatio *Time.deltaTime;
            CurrentScale = Mathf.Min(CurrentScale, BubbleMaxSize);
            PSBubble.Emit(20);
        }
        else if(CurrentScale >BubbleMinSize){
            CurrentScale -= BubbleDecreaseRatio* Time.deltaTime;
        }


        BubbleSprite.transform.localScale = Vector3.one *  CurrentScale ; 
    }
    private void FixedUpdate() {

        if(Input.GetKey(KeyCode.Space) && rigidbody.linearVelocityY < BubbleMaxVelocity){
            rigidbody.AddForceY(CurrentScale* BubbleUpBaseSpeed * Time.fixedDeltaTime);
        }
        if(Input.GetAxis("Horizontal") != 0)
        {
            rigidbody.AddForceX(Input.GetAxis("Horizontal") * BubbleSideSpeed * Time.fixedDeltaTime);
        }
    }
}
