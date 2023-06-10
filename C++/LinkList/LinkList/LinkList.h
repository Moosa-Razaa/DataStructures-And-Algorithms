#ifndef LINKLIST_H
#define LINKLIST_H

#include "../Node/Node.cpp"
#include <iostream>

class LinkList
{
    public:
        LinkList();
        void Add(int);
        void Print();
        void Delete();
        bool Contains(int);
        int IndexOf(int);
        void AddAfterAt(int, int);
    private:
        Node* head;
        Node* tail;
        void AddInitialNode(int);
        void Push(int);
        Node* PointerBeforeTail();
        void PrintSuccess(std::string);
};

#endif