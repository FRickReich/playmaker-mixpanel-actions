using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel Object Event")]

	public class  MixpanelObjectEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString ObjectnName;

		public FsmObject ObjectValue;
		
		public override void Reset()
		{
			EventName = null;
			ObjectnName = "";
			ObjectValue = null;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{ObjectnName.ToString(), ObjectValue.ToString()}
			});
			
			Finish();
			
		}
	}
}

