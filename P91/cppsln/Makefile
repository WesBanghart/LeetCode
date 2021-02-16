# the compiler: gcc for C program, define as g++ for C++
CXX = g++

#Libarries
LIBS = -lm

#Headers
HEADERS = Solution.h

#source
SRCS = main.cpp Solution.cpp

#create a list of object files
OBJECTS := $(patsubst %.cpp,%.o,$(SRCS))

# compiler flags:
#  -g     - this flag adds debugging information to the executable file
#  -Wall  - this flag is used to turn on most compiler warnings
CXX_FLAGS  = -g -Wall -std=c++11


# The build target 
TARGET = DecodeWays

all: $(TARGET)

%.o: %.cpp $(HEADERS)
	$(CXX) $(CXX_FLAGS) -c $< -o $@

$(TARGET): $(OBJECTS)
	$(CXX) $(CXX_FLAGS) $(OBJECTS) $(LIBS) -o $@

clean:
	-rm -f *.o
	-rm -f ./.depend
	-rm -f $(TARGET)