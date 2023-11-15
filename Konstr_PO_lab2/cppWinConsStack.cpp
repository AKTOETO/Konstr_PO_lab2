// Инфа тут 
// https://learn.microsoft.com/en-us/cpp/dotnet/how-to-create-clr-console-applications-cpp-cli?view=msvc-170
#include "stdafx.h"
using namespace System;

// 1.2  класс-стек строк
#include "stdafx.h"
using namespace System;

ref class Stack
{
	int MaxId;
	String^ StackId;
	int MaxSize;
	int top;
	array<String^>^ ST;

public:
	Stack(String^ mSize):
		top(0)
	{
		MaxSize = Convert::ToInt32(mSize);
		ST = gcnew array<String^>(MaxSize);
		MaxId++;
		StackId = Convert::ToString(MaxId);
		Console::WriteLine("Создан стек {0}!", StackId );
	};

	void push(String^ c)
	{
		if (top < MaxSize)
			ST[top++] = c;
		else Console::WriteLine("Стек переполнен!");
	}

	String^ pop()
	{
		if (top > 0)
			return ST[--top];
		else
		{
			Console::WriteLine("Стек пуст!");
			return "";
		}
	}
};
int main(array<String^>^ args)
{
	Stack^ vs;
	Console::WriteLine("Создать стек?");
	if (Console::ReadLine() == "да")
	{
		Console::WriteLine("какой глубины?");
		vs = gcnew Stack(Console::ReadLine()); 
	}
	// если стек создавать не нужно
	// выходим из программы
	else return 0;

	String^ s;
	// главный цикл программы
	do
	{
		Console::WriteLine("Что сделать?");
		s = Console::ReadLine();

		if (s == "заложить")
		{
			Console::WriteLine("Что?");
			vs->push(Console::ReadLine());
		}

		if (s == "достать")
			Console::WriteLine(vs->pop());

	} while (s != "");

	return 0;
}
