using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

    public Transform player;
    public float move_speed;
    public float rotation_speed;
    public Transform enemies;
    
    void Update()
    {
        var look_dir = player.position - enemies.position;
        look_dir.y = 0;
        enemies.rotation = Quaternion.Slerp(enemies.rotation, Quaternion.LookRotation(look_dir), rotation_speed * Time.deltaTime);
        enemies.position += enemies.forward * move_speed * Time.deltaTime;
    }
}
