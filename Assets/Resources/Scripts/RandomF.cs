using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class RandomF{

	public static int[] Range(int min, int max, int iteractions)
	{
		int total = iteractions >= max ? iteractions : max;

		List<NumChance> n = new List<NumChance>();
		for (int i = 0; i < max; i++)
			n.Add(new NumChance(i, 0));

		for (int i = 0; i < total; i++)
		{
			int val = Random.Range(0, max);
			n[val].chance++;
		}

		for (int i = 0; i < n.Count; i++)
			n[i].chance = ((n[i].chance / (float)total) * 100);

		n = n.OrderBy(o => o.chance).ToList();
		n.Reverse();

		int[] result = new int[max];
		for (int i = 0; i < n.Count; i++)
			result[i] = n[i].num + min;

		return result;
	}

	public class NumChance
	{
		public int num;
		public float chance;
		public NumChance(int num, float chance)
		{
			this.num = num;
			this.chance = chance;
		}
	}
}
