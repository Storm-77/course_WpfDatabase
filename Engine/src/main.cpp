#include <iostream>


extern "C" __declspec(dllexport) int __stdcall myFunction() {
	return 875;
}

