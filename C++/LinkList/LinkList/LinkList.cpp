#include "../Node/Node.h"
#include <iostream>

class LinkList
{
    Node* head;
    Node* tail;

    public:
        LinkList()
        {
            head = nullptr;
            tail = nullptr;
        }

        void Add(int number)
        {
            if(head == nullptr) AddInitialNode(number);
            else
            {
                Push(number);
            }

            PrintSuccess("Addition.");
        }

        void Delete()
        {
            if(head == nullptr) return;
            
            Node* ptrBeforeTail = PointerBeforeTail();
            delete (ptrBeforeTail->Next);
            ptrBeforeTail->Next = nullptr;
            tail = ptrBeforeTail;

            PrintSuccess("Deletion.");
        }

        void Print()
        {
            Node* nodePtr = head;

            while(nodePtr != nullptr)
            {
                std::cout << nodePtr->Data << std::endl;
                nodePtr = nodePtr->Next;
            }

            PrintSuccess("Print.");
        }

        bool Contains(int number)
        {
            Node* nodePtr = head;

            while(nodePtr != nullptr)
            {
                if(nodePtr->Data == number) return true;
                nodePtr = nodePtr->Next;
            }

            return false;
        }

        int IndexOf(int number)
        {
            int index = -1;

            Node* nodePtr = head;

            while(nodePtr != nullptr)
            {
                if(nodePtr->Data == number) return ++index;
                
                index++;
                nodePtr = nodePtr->Next;
            }

            return -1;
        }

        void AddAfterAt(int number, int indexToAdd)
        {
            Node* nodePtr = head;

            Node* newNode = new Node;
            newNode->Data = number;

            int index = 0;

            while(index < indexToAdd)
            {
                if(nodePtr == nullptr)
                {
                    std::cout << "Error! Can't add at specified index... Quitting operation." << std::endl;
                    return;
                }
                
                index++;
                nodePtr = nodePtr->Next;
            }

            newNode->Next = nodePtr->Next;
            nodePtr->Next = newNode;

            PrintSuccess("Addition at certain index.");
        }

    private:
        void AddInitialNode(int number)
        {
            Node* newNode = new Node;
            newNode->Data = number;
            newNode->Next = nullptr;

            head = newNode;
            tail = newNode;
       }

        void Push(int number)
        {
            Node* newNode = new Node;
            newNode->Data = number;
            newNode->Next = nullptr;

            tail->Next = newNode;
            tail = newNode;
        }

        Node* PointerBeforeTail()
        {
            Node* nodePtr = head;

            while(nodePtr->Next != tail) nodePtr = nodePtr->Next;

            return nodePtr;
        }

        void PrintSuccess(std::string operation)
        {
            std::cout << "Successfully ended: " << operation << std::endl;
        }
};