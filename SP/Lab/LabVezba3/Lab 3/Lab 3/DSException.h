#pragma once
#include <exception>

class DSException : public std::exception
{
public:
	DSException()
		:std::exception() {}
	DSException(char* message)
		:std::exception(message) {}
	DSException(std::exception& e)
		:std::exception(e) {}
};

