using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel Float Event")]

	public class  MixpanelFloatEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString FloatName;

		public FsmFloat FloatValue;
		
		public override void Reset()
		{
			EventName = null;
			FloatName = "";
			FloatValue = 0;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{FloatName.ToString(), FloatValue.ToString()}
			});
			
			Finish();
			
		}
	}
}

