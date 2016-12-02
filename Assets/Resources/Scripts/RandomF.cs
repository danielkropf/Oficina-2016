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

    public static GameObject[] FindSurroundings(GameObject me)
    {
        GameObject[] arroundMe = new GameObject[8];

        if (me.GetComponent<Movment>().immediatelyRight != null)
        {
            arroundMe[0] = me.GetComponent<Movment>().immediatelyRight;

            if (me.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp != null)
            {
                arroundMe[1] = me.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp;
            }
            if (me.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown != null)
            {
                arroundMe[2] = me.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown;
            }
        }

        if (me.GetComponent<Movment>().immediatelyDown != null)
        {
            arroundMe[3] = me.GetComponent<Movment>().immediatelyDown;
        }

        if (me.GetComponent<Movment>().immediatelyLeft != null)
        {
            arroundMe[4] = me.GetComponent<Movment>().immediatelyLeft;

            if (me.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp != null)
            {
                arroundMe[5] = me.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp;
            }

            if (me.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown != null)
            {
                arroundMe[6] = me.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown;
            }
        }

        if (me.GetComponent<Movment>().immediatelyUp != null)
        {
            arroundMe[7] = me.GetComponent<Movment>().immediatelyUp;
        }

        return arroundMe;
    }
}
