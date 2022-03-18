import sys
sys.path.insert(0,'C:\Python39\Lib\site-packages')
import bluetooth as b
target_name = "Blood Pressure Monitor"
target_address = None
nearby_devices = b.discover_devices()
for address in nearby_devices:
    if target_name == b.lookup_name( address ):
        target_address = address
        break
    if target_address is not None:
        print ("found target bluetooth device with address ", target_address)
    else:
        print ("could not find target bluetooth device nearby")
        print (nearby_devices)
        

