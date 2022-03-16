#pragma once

#ifdef PROJECT_ENGINE
	#define DLL_INTERFACE __declspec(dllexport)
#else
	#define DLL_INTERFACE __declspec(dllimport)
#endif