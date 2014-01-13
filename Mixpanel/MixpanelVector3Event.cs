using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel Vector3 Event")]

	public class  MixpanelVector3Event : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString Vector3Name;

		public FsmVector3 Vector3Value;
		
		public override void Reset()
		{
			EventName = null;
			Vector3Name = "";
			Vector3Value = null;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{Vector3Name.ToString(), Vector3Value.ToString()}
			});
			
			Finish();
			
		}
	}
}

