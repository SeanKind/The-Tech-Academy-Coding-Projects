import checkFiles
from tkinter import *
import tkinter as tk

def loadGui(self):
    
    self.btnBrowse1 = tk.Button(self.master,text='Browse...')
    self.btnBrowse1.grid(row=0,column=0,padx=(10,30),pady=(10,10),sticky=W+E)

    self.btnBrowse2 = tk.Button(self.master,text='Browse...')
    self.btnBrowse2.grid(row=1,column=0,padx=(10,30),pady=(10,10),sticky=W+E)

    self.btnCheck = tk.Button(self.master,text='Check for files...')
    self.btnCheck.grid(row=2,column=0,rowspan=1,padx=(10,30),sticky=W+E)

    self.btnClose = tk.Button(self.master,text='Close Program')
    self.btnClose.grid(row=2,column=2,rowspan=1,padx=(10,0),sticky=E)

    self.txtEntry1 = tk.Entry(self.master,text='')
    self.txtEntry1.grid(row=0,column=1,columnspan=2,sticky=W+E)

    self.txtEntry2 = tk.Entry(self.master,text='')
    self.txtEntry2.grid(row=1,column=1,columnspan=2,sticky=W+E)

if __name__ == "__main__":
    pass
