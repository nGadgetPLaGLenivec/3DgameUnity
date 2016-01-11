using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public GameObject player;
    public float move_speed;
    public float rotation_speed;
    public Transform enemies;
    public float spawn_time = 3f;
    public Transform[] spawn_points;


    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawn_time, spawn_time);
    }

    void Update()
    {
        var look_dir = player.transform.position - enemies.position;
        look_dir.y = 0;
        enemies.rotation = Quaternion.Slerp(enemies.rotation, Quaternion.LookRotation(look_dir), rotation_speed * Time.deltaTime);
        enemies.position += enemies.forward * move_speed * Time.deltaTime;
    }
    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawn_points.Length);
        //  Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(enemies, spawn_points[spawnPointIndex].position, spawn_points[spawnPointIndex].rotation);
    }
}