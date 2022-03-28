import socket            
 
# Create a socket object
s = socket.socket()        
 
# Define the port on which you want to connect
port = 12345               
print('client attempting to connect')
# connect to the server on local computer
s.connect(('localhost', port))
while True:
    # receive data from the server and decoding to get the string.
    print (s.recv(1024).decode())
    print('connected?')
    # close the connection
    s.close()    
     


