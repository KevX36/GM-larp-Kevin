using UnityEngine;

public class lerpCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    static float timer = 0.0f;
    public GameObject cube;
    // Update is called once per frame
    void Update()
    {
        Vector3 start = transform.position;
        Vector3 end = transform.position;
        int dis = 5;
        end.x = dis;
        timer = Time.deltaTime;
        transform.position = Vector3.Lerp(start, end, timer);
        if (timer >= 1)
        {
            timer = 0.0f;
        }
    }
}
