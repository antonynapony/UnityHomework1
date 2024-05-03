using UnityEngine;

public class SpawnPrefabs : MonoBehaviour
{
    public GameObject[] prefabs;
    public float speed = 1.9f;
    public GameObject instance;
    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (instance != null)
            {
                Destroy(instance);
            }
            int random = Random.Range(0, prefabs.Length);
            var rotation = Quaternion.identity;
            var position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            instance = Instantiate(prefabs[random], position, rotation);
        }
    }
}
