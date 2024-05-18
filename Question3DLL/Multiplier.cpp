#include "pch.h"

extern "C" __declspec(dllexport) int Multiply(int a, int b)
{
    return a * b;
}