using UnityEngine;

public class HumanCollision : MonoBehaviour
{
    private Human human;

    private void Start() 
    {
        human = GetComponentInParent<Human>();    
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.TryGetComponent<FloorCollision>(out _))
        {
            human.isOnFloor = true;
        }    
    }

    private void OnCollisionExit(Collision other) 
    {
        if(other.gameObject.TryGetComponent<FloorCollision>(out _))
        {
            human.isOnFloor = false;
        }  
    }
}
