using UnityEngine;

public class SpinObScript : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Make the GameObject spin
        transform.Rotate(new Vector3(0, speed, 0) * Time.deltaTime);
    }
}
