using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace talkkit
{
    [RequireComponent(typeof(Text))]
    public class MessageHandle : MonoBehaviour
    {
        public float m_fDelay = 0.025f;
        private Text m_txtMessage;
        public Text text_message
        {
            get
            {
                if(m_txtMessage == null)
                {
                    m_txtMessage = GetComponent<Text>();
                }
                return m_txtMessage;
            }
        }

        public IEnumerator Request( string _strMessage)
        {
            for( int i = 0; i < _strMessage.Length; i++)
            {
                text_message.text = _strMessage.Substring(0, i+1);
                yield return new WaitForSeconds(m_fDelay);
            }
        }

        public void Test(string _strMessage)
        {
            StartCoroutine(Request(_strMessage));
        }
    }
}