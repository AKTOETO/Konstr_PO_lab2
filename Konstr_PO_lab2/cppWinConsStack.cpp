// Инфа тут 
// https://learn.microsoft.com/en-us/cpp/dotnet/how-to-create-clr-console-applications-cpp-cli?view=msvc-170
#include "stdafx.h"
using namespace System;

// 1.1 стек строк (не класс)
static int MaxSize = 100;
static int top = 0;
static void push(String^ c, array<String^>^ st)
{
	// если максимальный размер стека не превышен
	// то можем добавить элемент
	if (top < MaxSize)
		st[top++] = c;

	// иначе не добавляем
	else Console::WriteLine("Стек переполнен!");
}
static String^ pop(array<String^>^ st)
{
	// если стек не пуст
	if (top > 0)
		return st[--top];

	// если же стек пуст
	Console::WriteLine("Стек пуст!");
	return "";
}
int main(array<String^>^ args)
{
	// создаем стек
	array<String^>^ ST = gcnew array<String^>(MaxSize);

	// строка для работы с консолью
	String^ s;

	// главный цикл
	do
	{
		Console::WriteLine("Что сделать?");
		s = Console::ReadLine();
		
		if (s == "заложить")
		{
			Console::WriteLine("Что?");
			push(Console::ReadLine(), ST);
		}

		if (s == "достать")
			Console::WriteLine(pop(ST));

	} while (s != "");
}


//ref class Stack {
//private:
//    cli::array<String^>^ st;
//    int top;
//
//public:
//    Stack()
//	{
//        st = gcnew cli::array<String^>(100);
//        top = 0;
//    }
//
//    void push(String^ s)
//	{
//        if (top < 100)
//		{
//            st[top] = s;
//            top++;
//        }
//        else
//		{
//            Console::WriteLine("Stack is full");
//        }
//    }
//
//    String^ pop()
//	{
//        if (top > 0)
//		{
//            top--;
//            return st[top];
//        }
//        else 
//		{
//            Console::WriteLine("Stack is empty");
//            return nullptr;
//        }
//    }
//};
//
//int main(cli::array<System::String^>^ args)
//{
//    Stack^ stack = gcnew Stack();
//    String^ input;
//
//    do {
//        Console::WriteLine("What to do?");
//        input = Console::ReadLine();
//        if (input == "push")
//		{
//            Console::WriteLine("Enter a string to push:");
//            String^ s = Console::ReadLine();
//            stack->push(s);
//        }
//        else if (input == "pop") 
//		{
//            Console::WriteLine(stack->pop());
//        }
//    } while (input != "exit");
//
//    return 0;
//}
