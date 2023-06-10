#include <iostream>
#include "LinkList/LinkList.cpp"

using namespace std;

int main()
{
    LinkList linkedList;

    linkedList.Add(10);
    linkedList.Add(20);
    linkedList.Add(30);
    linkedList.Add(40);

    linkedList.AddAfterAt(15, 1);

    linkedList.Print();

    return 0;
}