using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace talkkit
{
    [CustomEditor(typeof(MessageHandle))]
    public class MessageHandleEditor : Editor
    {
        string test_message = "テストメッセージ";
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();


            MessageHandle script = target as MessageHandle;
            test_message = GUILayout.TextArea(test_message);
            if( GUILayout.Button("TestMessage"))
            {
                Debug.Log(test_message);
                script.Test(test_message);
            }
        }
    }
}

