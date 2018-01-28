#!/usr/bin/env python

#pretty obvious, but you'll want these dependencies to be installed for this script to work
import RPi.GPIO as GPIO, time, requests, os

def cls():
    os.system(['clear','cls'][os.name == 'nt'])

DEBUG = 1

led1 = 4
led2 = 17
led3 = 27
led4 = 22

GPIO.setmode(GPIO.BCM)
GPIO.setup(led1, GPIO.OUT)
GPIO.setup(led2, GPIO.OUT)
GPIO.setup(led3, GPIO.OUT)
GPIO.setup(led4, GPIO.OUT)

response = requests.get('http://augmented.host-ed.me/test.php')

while response.text != '00001':
    response = requests.get('http://augmented.host-ed.me/test.php')

    colrs = response.text
    r1 = colrs[0]
    r2 = colrs[1]
    r3 = colrs[2]
    r4 = colrs[3]

    cls()

    if response.text == '00001':
        print (colrs)
    else:
	print (" WELCOME TO HOME AUTOMATION THROUGH INTERNET ")
        print (" LED1 - " + r1 + ", "),
        print ("LED2 - " + r2 + ", "),
	print ("LED3 - " + r3 + ", "),
        print ("LED4 - " + r4)
        print

    if r1 == '1':
        GPIO.output(led1,True)
    else:
        GPIO.output(led1,False)
    if r2  == '1':
        GPIO.output(led2,True)
    else:
        GPIO.output(led2,False)
    if r3  == '1':
        GPIO.output(led3,True)
    else:
        GPIO.output(led3,False)
    if r4  == '1':
        GPIO.output(led4,True)
    else:
        GPIO.output(led4,False)

    #time.sleep(0.25) #uncomment this if you want the polling loop to be slower