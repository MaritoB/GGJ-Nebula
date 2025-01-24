using UnityEngine;

public class BubbleHandler : MonoBehaviour
{
    [SerializeField]
    float BubbleDecreaseRatio;
    [SerializeField]
    float BubbleIncreaseRatio;
    [SerializeField]
    float BubbleUpBaseSpeed;
    [SerializeField]
    Transform BubbleSprite;
    
    [SerializeField]
    float StartSize;
    [SerializeField]
    float CurrentScale;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentScale = StartSize;
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentScale >0){
            CurrentScale -= BubbleDecreaseRatio* Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.Space)){
            CurrentScale +=BubbleIncreaseRatio *Time.deltaTime;
        }

        BubbleSprite.transform.localScale = Vector3.one *  CurrentScale ;
        transform.position.
    }
}
