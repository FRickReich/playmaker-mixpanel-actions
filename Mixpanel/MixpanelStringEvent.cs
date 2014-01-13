using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel String Event")]

	public class  MixpanelStringEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString StringName;

		public FsmString StringValue;
		
		public override void Reset()
		{
			EventName = null;
			StringName = "";
			StringValue = "";
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{StringName.ToString(), StringValue.ToString()}
			});
			
			Finish();
			
		}
	}
}

