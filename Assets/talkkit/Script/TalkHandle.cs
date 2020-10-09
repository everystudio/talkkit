using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace talkkit
{
	public class TalkHandle : MonoBehaviour
	{
		public bool m_bIsTalking = false;
		public MessageHandle m_messageHandle;
		public IEnumerator Talk(TalkData _data , Action _onFinished)
		{
			m_bIsTalking = true;
			for ( int i = 0; i < _data.message_list.Count; i++)
			{
				yield return StartCoroutine(m_messageHandle.Request(_data.message_list[i]));
				while(!Input.GetMouseButtonDown(0))
				{
					yield return null;
				}
			}
			m_bIsTalking = false;
			_onFinished.Invoke();
		}


	}
}
