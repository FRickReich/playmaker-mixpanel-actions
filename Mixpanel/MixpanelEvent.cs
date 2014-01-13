using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Empty Mixpanel Event")]

	public class  MixpanelEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		public override void Reset()
		{
			EventName = "";
		}
		
		public override void OnEnter() {
			
			if (EventName!=null)
			{
				Mixpanel.SendEvent(EventName);
			}
			
			Finish();
			
		}

	}
}