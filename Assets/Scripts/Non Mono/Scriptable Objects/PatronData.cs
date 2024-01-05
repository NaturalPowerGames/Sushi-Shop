using UnityEngine;

namespace Patrons
{
	[CreateAssetMenu]
	public class PatronData : ScriptableObject
	{
		public PatronController[] Patrons;
	}
}