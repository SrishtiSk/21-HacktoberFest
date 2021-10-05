#Python program which accepts the radius of a circle from the user and compute the area.
from math import pi
radius=float(input("enter the radius: "))
print("Area of the circle with radius "+str(radius)+ "is: "+ str(float(pi* radius**2)))
