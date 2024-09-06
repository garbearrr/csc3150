using UnityEngine;

public class TableScript : MonoBehaviour
{
    [SerializeField]
    private float xMove = 0.0f;

    [SerializeField]
    private float yMove = 0.0f;

    [SerializeField]
    private float zMove = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //"I am a component added to the prefab"
        print("I am a component added to the prefab");
    }

    // Update is called once per frame
    void Update()
    {
        print("I update with every frame of the prefab");
        transform.position = new Vector3(transform.position.x + xMove, transform.position.y + yMove, transform.position.z + zMove);
    }
}
