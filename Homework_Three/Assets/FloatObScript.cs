using UnityEngine;

public class FloatObScript : MonoBehaviour
{
    [SerializeField] private float startY = 5f;

    [SerializeField] private float invisTimeSec = 5f;

    private float origY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.origY = transform.position.y;
        // Put the GameObject at the start Y position
        transform.position = new Vector3(transform.position.x, startY, transform.position.z);
        // Make the GameObject invisible
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // After invisTimeSec seconds, make the GameObject visible
        if (Time.time > invisTimeSec)
        {
            if (transform.position.y <= origY)
            {
                return;
            }

            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.enabled = true;

            // Drop the GameObject
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime;
        }
    }
}
