using UnityEngine;

namespace Patrons
{
	[CreateAssetMenu]
	public class PatronData : ScriptableObject
	{
		public PatronController[] Patrons;

		public PatronController GetRandomPatron()
		{
			int randomIndex = UnityEngine.Random.Range(0, Patrons.Length);
			return Patrons[randomIndex];
		}
	}
}