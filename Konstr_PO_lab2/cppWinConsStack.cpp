
#include "stdafx.h"
using namespace System;
using namespace std;

ref class Stack {
private:
    cli::array<String^>^ st;
    int top;
public:
    Stack() {
        st = gcnew cli::array<String^>(100);
        top = 0;
    }

    void push(String^ s) {
        if (top < 100) {
            st[top] = s;
            top++;
        }
        else {
            Console::WriteLine("Stack is full");
        }
    }

    String^ pop() {
        if (top > 0) {
            top--;
            return st[top];
        }
        else {
            Console::WriteLine("Stack is empty");
            return nullptr;
        }
    }
};

int main(cli::array<System::String^>^ args)
{
    Stack^ stack = gcnew Stack();
    String^ input;

    do {
        Console::WriteLine("What to do?");
        input = Console::ReadLine();
        if (input == "push") {
            Console::WriteLine("Enter a string to push:");
            String^ s = Console::ReadLine();
            stack->push(s);
        }
        else if (input == "pop") {
            Console::WriteLine(stack->pop());
        }
    } while (input != "exit");

    return 0;
}