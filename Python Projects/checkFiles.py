from tkinter import *
import tkinter as tk


import checkFilesGui


class ParentWindow(Frame):
    def __init__(self, master, *args, **kwargs):
        Frame.__init__(self, master, *args, **kwargs)

        self.master = master
        self.master.minsize(500,150)
        self.master.maxsize(500,150)
        self.master.title("Check Files")

        width = 1
        root.grid_columnconfigure(0, weight=1, minsize=1)
        root.grid_columnconfigure(1, weight=1, minsize=1)
        root.grid_columnconfigure(2, weight=1, minsize=1)
        root.grid_columnconfigure(3, weight=1, minsize=1)
        #root.grid_rowconfigure(0, weight=1)
        #root.grid_rowconfigure(1, weight=1)
        #root.grid_rowconfigure(2, weight=1, minsize=1)
        #root.grid_rowconfigure(3, weight=1, minsize=1)

        checkFilesGui.loadGui(self)


if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()
