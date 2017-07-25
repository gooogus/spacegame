#pragma strict

    var speed : float = 1.0;
    var spaceShip : Transform;
    private var posX = 0;
    private var posZ = -80;

    function Update () {

 		if (Input.GetKey(KeyCode.W)) {
 			posZ += speed;
    	} else if (Input.GetKey(KeyCode.S)) {
    		posZ -= speed;
    	}

    	if (Input.GetKey(KeyCode.A)) {
 			posX -= speed;
    	} else if (Input.GetKey(KeyCode.D)) {
    		posX += speed;
    	}

    	posZ = (Mathf.Clamp(posZ, -55, 55));

    	posX = (Mathf.Clamp(posX, -85, 40));

    	spaceShip.transform.position.z = posZ;

    	spaceShip.transform.position.x = posX;



    }