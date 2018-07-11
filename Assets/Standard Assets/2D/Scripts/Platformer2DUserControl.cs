using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
	public class Platformer2DUserControl : NetworkBehaviour 
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
		public static float h;

		public override void OnStartLocalPlayer ()
		{
			GetComponent<SpriteRenderer>().color = Color.green;
		}


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {

			if (!isLocalPlayer)
			{
				return;
			}


            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }

		[Command]
		public void CmdImpulse(){
			if(isLocalPlayer){
				h += 0.3f;
				Debug.Log ("IMPULSE");
			}
		}

		public void stop(){
			h = 0;
		}


        private void FixedUpdate()
        {

			if (!isLocalPlayer)
			{
				return;
			}


            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);

            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
			if(h>0) h-= 0.001f;
			//Debug.Log ("h:" + h + "c:" + crouch + "j:" + m_Jump);
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump);
            m_Jump = false;
        }
    }
}
