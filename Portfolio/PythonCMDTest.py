#!/usr/bin/python

import time,sys,argparse,math

#parse through command line arguments
parser = argparse.ArgumentParser(description='Command line arguments')
parser.add_argument('-n','--times',help='Number of times repeated',required=True)
parser.add_argument('-t','--wait',help='Time waited between prints',required=True)
parser.add_argument('-w','--word',help='String to be iterated',required=True)
args = parser.parse_args()

#initialize variables
maxTimes = int(args.times)
waitTime = float(args.wait)
itString = str(args.word)
curTimes = 1

#iterate until max times reached, printing sin wave of word
while(curTimes <= maxTimes):
	curTimes+=0.1
	iteration = int((math.sin(curTimes)+1)*30)
	outString = ""
	for index in range(0,iteration):
		outString = outString + itString[index%len(itString)]
	print(outString)
	del outString
	time.sleep(waitTime)

print("Program completed successfully...\a")