using UnityEngine;

public class lerpCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 start = new Vector3(0, 1.5f, 0);
    Vector3 end = new Vector3(5, 1.5f, 0);
    void Start()
    {
        
    }
    float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        
        
        timer += Time.deltaTime;
        transform.position = Vector3.Lerp(start, end, timer);
        if (timer >= 1.0f)
        {
            timer = 0.0f;
        }
        
    }
}
