import socket                

s = socket.socket()          
print ("Socket successfully created")

port = 12345                

s.bind(('192.168.8.130', port))         
print("socket binded to %s" %(port))

s.listen(5)      
print ("socket is listening")            

while True: 

   c, addr = s.accept()      
   print ('Got connection from', addr)
   data = c.recv(1024).decode()
   print(data)

   c.send('This is Windows Laptop. Thank you for connecting'.encode())

   c.close() 