using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace talkkit
{

	[CreateAssetMenu(fileName = "TalkData", menuName = "Data/TalkData")]
	public class TalkData : ScriptableObject
	{
		public List<string> message_list = new List<string>();
	}
}
