import selectDir
from tkinter import *
import tkinter as tk
import tkinter.filedialog
import os


def pickDir(self):
    Path = tk.filedialog.askdirectory()
    self.dirPath.set(Path)
    print(Path)
    


def loadGui(self):
    self.dirPath = StringVar()
    self.btnSeldir = tk.Button(self.master,text='Select Directory', command=lambda:pickDir(self))
    self.btnSeldir.grid(row=0,column=0)

    self.labShowDir = tk.Label(self.master,textvariable=self.dirPath)
    self.labShowDir.grid(row=1,column=0)
    








if __name__ == "__main__":
    pass
