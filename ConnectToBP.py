import sys
sys.path.insert(0,'C:\Python39\Lib\site-packages')
import bluetooth as b

nearby_devices = b.discover_devices()
print("Scan for monitor started")
print("Found Devices: ")
[print(x) for x in nearby_devices]          #finds all bluetooth devices

BPMac = "00:8A:76:48:7F:1F"                 #static MAC address of BP monitor
result = str(nearby_devices)                #converts MAC address of found devices to string
for x in result:                            #checks if monitor is in found list
    if result == BPMac:
        print("Found Monitor")
    else:
        print("Unable to detect monitor")

