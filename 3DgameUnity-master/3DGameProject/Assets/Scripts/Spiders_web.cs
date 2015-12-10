using UnityEngine;


public class Spiders_web : MonoBehaviour {
    // Use this for initialization
    bool inWeb = false;
    UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter slow;
    void Start ()
    {
        slow = GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>();
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
        if (collision.gameObject.name == "Spiders_web")
        {
            inWeb = true;
       
            slow.m_MovingTurnSpeed = 0F;
            slow.m_MoveSpeedMultiplier = 0.3F;

        }
        else
        {
            inWeb = false;
            slow.m_MovingTurnSpeed = 360;
            slow.m_MoveSpeedMultiplier = 1F;
        }
    }

}
