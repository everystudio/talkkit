using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using talkkit;

public class TalkTest : MonoBehaviour
{
	public TalkData data;
	public TalkHandle m_talkHandle;

	public void Talk()
	{
		if (m_talkHandle.m_bIsTalking == false)
		{
			StartCoroutine(m_talkHandle.Talk(data, () =>
			{
				Debug.Log("Message Finished");
			}));
		}
	}


}
