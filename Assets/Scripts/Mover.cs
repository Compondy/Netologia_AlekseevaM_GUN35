using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
	public Vector3 _start;
	public Vector3 _end;
	public float _speed;
	public float _delay;
	private float passed;
	int reverse = 1;
	private IEnumerator Start()
    {
		var body = GetComponent<Rigidbody>();
		if(_start == _end) yield break;

		while(true)
		{
			passed += Time.deltaTime;
			float scale = passed * _speed;
			if (scale <= 1)
			{
				if (reverse == 1)
					body.transform.position = Vector3.Lerp(_start, _end, passed * _speed);
				else
                    body.transform.position = Vector3.Lerp(_end, _start, passed * _speed);
            }
			else
			{
				passed = 0;
				reverse *= -1;
                yield return new WaitForSeconds(_delay);
            }

			yield return null;
		}
	}
}
