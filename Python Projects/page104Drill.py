import sqlite3

conn = sqlite3.connect('test.db')

with conn:
    cur = conn.cursor()
    cur.execute("CREATE TABLE IF NOT EXISTS checker (ID INTEGER PRIMARY KEY AUTOINCREMENT, fileName TEXT)")
    conn.commit()
conn.close()

fileList = ('information.docx','Hello.txt','myImage.png','myMovie.mpg','World.txt','data.pdf','myPhoto.jpg')

for item in fileList:
    test = item
    if test.endswith('.txt'):
        
        conn = sqlite3.connect('test.db')
        with conn:
            cur = conn.cursor()
            cur.execute("INSERT INTO checker(fileName) VALUES (?)", (item,))
            conn.commit()
        conn.close()
conn = sqlite3.connect('test.db')
with conn:
    cur = conn.cursor()
    cur.execute("SELECT fileName FROM checker")
    file = cur.fetchall()
    for item in file:
        print(item)
    
