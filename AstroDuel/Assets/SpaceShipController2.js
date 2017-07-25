#pragma strict

    var speed : float = 1.0;
    private var pos = 0;
    var spaceShip2 : Transform;

    function Update () {

    	if (Input.GetKey(KeyCode.I)) {
 			pos += speed;
    	} else if (Input.GetKey(KeyCode.K)) {
    		pos -= speed;
    	}

    	pos = (Mathf.Clamp(pos, -55, 55));

    	spaceShip2.transform.position.z = pos;

    }