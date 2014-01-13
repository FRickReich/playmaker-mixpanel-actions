using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel Int Event")]

	public class  MixpanelIntEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString IntName;

		public FsmInt IntValue;
		
		public override void Reset()
		{
			EventName = null;
			IntName = "";
			IntValue = 0;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{IntName.ToString(), IntValue.ToString()}
			});
			
			Finish();
			
		}
	}
}

