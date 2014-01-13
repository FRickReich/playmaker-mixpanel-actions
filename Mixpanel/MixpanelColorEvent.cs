using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel Color Event")]

	public class  MixpanelColorEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString ColorName;

		public FsmColor ColorValue;
		
		public override void Reset()
		{
			EventName = null;
			ColorName = "";
			ColorValue = null;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{ColorName.ToString(), ColorValue.ToString()}
			});
			
			Finish();
			
		}
	}
}

