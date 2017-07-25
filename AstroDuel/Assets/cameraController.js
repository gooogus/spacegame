var cameraObject : Transform;
var nextField = 40.0;
var dampVelocity2 = 0.8;
 
 function Update () {

    var newField = Mathf.SmoothDamp(Camera.main.fieldOfView, nextField, dampVelocity2, .8);

    Camera.main.fieldOfView = newField;
    
    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
        //adjust viewpoint and gun position
        nextField = 55.0;

    } else {
        //adjust viewpoint and gun position
        nextField = 53.0;

    }

    if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) {
        //adjust viewpoint and gun position
        nextField = 160.0;

    }

 }