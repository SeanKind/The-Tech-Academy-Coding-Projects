import os
import time


fName = 'B'
fPath = 'C:\\Users\\Sean\\Documents\\GitHub\\The-Tech-Academy-Basic-Python-Projects\\A\\B'
fAbso = os.path.join(fPath,fName)
listDir = os.listdir(fPath)
print("files in '", fPath, "'that end in .txt :")
# print(listDir)
for file in os.listdir(fPath):
    if file.endswith(".txt"):
        print(file)
        time = os.path.getmtime(fPath)
        print("Last modification time(Local time): ", time)
