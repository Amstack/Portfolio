#CSC 461 R Homework
#Alex Stack 11/25/19

mainFunc <- function() {

#1 Block Scope
#Supports block scope
if(T) {
  a <- "block"
} else {
  a <- 15
}
print(a)

#2 Function scope
#Supports function scope
#x inside the function is a different variable than outside
x <- "string"
block <- function() {
  x <- 12
  print(x)
}
block()
print(x)

#3 Nested subprograms
parentFunc <- function(x) {
  x <- x + 1
  childFunc1 <- function(x) {
    childFunc2 <- function(x) {
      x <- x * 5
    }
    x <- childFunc2(x)
    return(x)
  }
  print(childFunc1(x))
}
parentFunc(2)

#4 Value or reference model
#Value model, when passed y it does not change y,
#only receives it's value
y <- 1
valFunc <- function(int) {
  int <- 2
}
valFunc(y)
print(y)

#5 L and R values
#There are both, the L-value is lv (a variable reserved
#in memory) and the R-Value is 5,6,7 (data)
#In R the L-value can be on the left or right side
lV <- 5
6 -> lV
lv = 7

#6 mutable and immutable values
#Objects in R are immutable, R creates a new object
#instead of changing the existing one
#Below will print 2 differing memory addresses, meaning
#R created a new variable
mutable <- 5
tracemem(mutable)
mutable <- 6
tracemem(mutable)

#7 Passing arguments
#R circumvents this by allowing parameters to take
#default values. R also lets you directly reference
#a function's parameter, allowing users to call a function
#without providing all parameters
weirdFunc <- function(a=NULL,b=F,c="Tree") {
  print(a)
  print(b)
  print(c)
}
weirdFunc(c=20,b="Stuff")

#8 Garbage value
#It is somewhat possible, R will default a variable to 
#some data type, however it may be a null or non-existent
#data type. This example reserves memory space but the value
#is not useful for any calculation
garbage <- NA
tracemem(garbage)
print(typeof(garbage))

#9 Strongly Typed
#R is strongly typed, with each variable requiring some
#data type. R does not support operations between clashing
#data types, but will coerce compatible types
strongString <- "Words"
strongInt <- 10
#strongRes <- (strongString + strongInt) #causes error
print(typeof(strongString))
print(typeof(strongInt))

#10 Dynamically typed
#R is dynamically typed; the language with automatically
#assign or append a type to a variable
dynVar = 10
dynVar = c(1,2,3,4)
dynVar = "String"

#11 Type constructors
#R provides inherent type constructors
vec <- vector("numeric",10)
print(vec)

#12 Compatible types
#(1) vector and float are compatible (adds float to each vec entry)
#(2) numeric and boolean are compatible (bool coerced into 0/1 and added)
testVec = c(1,2,3)
testFloat = 5.5
testBool = T
testInt = 5

testAdd <- testVec + testFloat
testAdd2 <- testInt + testBool
print(testAdd)
print(testAdd2)

}