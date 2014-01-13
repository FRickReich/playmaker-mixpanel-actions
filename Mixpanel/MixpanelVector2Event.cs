using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel Vector2 Event")]

	public class  MixpanelVector2Event : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString Vector2Name;

		public FsmVector2 Vector2Value;
		
		public override void Reset()
		{
			EventName = null;
			Vector2Name = "";
			Vector2Value = null;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{Vector2Name.ToString(), Vector2Value.ToString()}
			});
			
			Finish();
			
		}
	}
}

