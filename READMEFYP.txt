
-----------Welcome to the Polygraph Application README File--------------


In order to run the project, the end user must have access to a PulseExpress bio sensor and Raspberry Pi. This project is built upon 
sensor data. In addition, the end user must have access to an Azure database. This software program can however run on its own
without the sensors as well.

To run the application using the sensors, please connect the sensor to the Arduino, and the Arduino to the Raspberry Pi. From here,
please navigate to the file PulseExpressFinalScript.ino. Click on this, and this will bring you into the Arduino editor. Upload this
script to the Arduino. The light on the Arduino should blink in response. From here, you should navigate to the Azure portal and 
start running the Polygraph IoT Hub, as well as the Stream Analytics job. The Start button is located at the top of the job's dashboard.
You can navigate to these resources by searching for them in the search bar on the Azure portal. In addition, please do the same for the
PolygraphDB and make sure that database is active.
After this is done, please navigate to the ArduinoToPiLatest.py file. Run this file. Messages should now be sending from the
console to the IoT Hub. This can be validated with access to an Azure IoT Hub Explorer.

If the end user wants to run the software application by itself, the instructions on how to do it are as follows:
Please navigate to the solution file. This will open Visual Studio. If you do not have Visual Studio 19, please install it.
Once in the program, to begin the application, please select "Build" and 
then "start without" debugging. You will be prompted for a username and password. For the purposes of this application
the username is "testUser" and the password is "testPass." These can be entered into the fields to gain access to the system.

From here, you can select from a range of options, including "Configure test", "View Subjects", "View Questions", and "Update Credentials"
At some points during the application you may be prompted for the username and password again.

To end the application, please select "Logout", or you can close the window using the X on the top right-hand corner