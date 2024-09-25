using Message_Manipulator;
//Simple program, requests a message to be entered, which should be entered in the format #m<n><space><message body>
Console.Write("Message= ");

//there is no invalid input here, so errors can be caused by this.
string msg = Console.ReadLine();

//create manipulator object and pass the msg string.
Manipulator manipulation = new Manipulator();
manipulation.Manipulate(msg);


