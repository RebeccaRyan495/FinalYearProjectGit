import os
import time
import serial
import asyncio
import serial
from azure.iot.device import IoTHubDeviceClient, Message
from uuid import uuid4
import json

conn_str ="HostName=PolygraphIOT.azure-devices.net;DeviceId=RaspberryPi;SharedAccessKey=WGqU6mmYD85OYM17BZUPQsYaiJ2SI9bITsljo37XkF4="

    # Create instance of the device client using the connection string
device_client = IoTHubDeviceClient.create_from_connection_string(conn_str)
device_client.connect()

def generateUUID():
    return str(uuid4())

def main():
    
    for i in range(50):
        ser = serial.Serial('/dev/ttyUSB0', 57600)
        time.sleep(0)
        b=ser.readline()
        print(b)
        print("Sending message...")
        #msg = Message(b)
        #msg.message_id = generateUUID()
        #msg.content_encoding = "utf-8"
        #msg.content_type ="application/json"
        #JSON_ = json.dumps(b)
        #nowString = b.decode("utf-8").replace("'", '"')
        #print(nowString)
        #toJSON = json.loads(nowString)
        #s = json.dumps(toJSON, indent=4, sort_keys=True)
        
        hi = b.decode("utf-8").replace("'", '"')
        
        data = {
                "Value":hi
            }
        print(json.dumps(data))
        nowJSON = json.dumps(data)
        device_client.send_message(nowJSON)
        print("Message successfully sent!")
    ser.close()
    device_client.shutdown()


if __name__ == "__main__":
    #asyncio.run(main())

    # If using Python 3.6 use the following code instead of asyncio.run(main()):
     loop = asyncio.get_event_loop()
     loop.run_until_complete(main())
     loop.close()
