using UnityEngine;


public class Spider_web : MonoBehaviour {
    // Use this for initialization
    bool inWeb = false;
    UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter slow;
    void Start () {
  
    }
	
	// Update is called once per frame
	void Update () {
        /*if (!inWeb)
        {
            slow.m_MovingTurnSpeed = 360;
            slow.m_MoveSpeedMultiplier = 1F;
        }*/
    }
    void OnCollisionEnter(Collision collision)
    {
        slow = GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>();
        if (collision.gameObject.name == "web_spider")
        {
            inWeb = true;
       
            slow.m_MovingTurnSpeed = 0F;
            slow.m_MoveSpeedMultiplier = 0.3F;

        }
        else
        {
            slow.m_MovingTurnSpeed = 360;
            slow.m_MoveSpeedMultiplier = 1F;
        }
    }

}
