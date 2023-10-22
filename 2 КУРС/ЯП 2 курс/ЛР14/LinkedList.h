#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

struct Node
{
	string value;
	Node* next;
	Node(string data)
	{
		value = data;
		next = nullptr;
	}
	Node(string data, Node* nextPtr)
	{
		value = data;
		next = nextPtr;
	}
	~Node() {};
};

class LinkedList
{
public:

	Node* head;
	int size;

	LinkedList()
	{
		head = nullptr;
		size = 0;
	}

	LinkedList(const LinkedList& q)
	{
		LinkedList p;
		Node* curPtr = q.head;
		for (size_t i = 0; i < q.size; i++)
		{
			p.AddLast(curPtr->value);
			curPtr = curPtr->next;
		}
		head = p.head;
		size = p.size;
	}

	LinkedList operator=(const LinkedList& q)
	{
		Node* curPtr = q.head;
		(*this).Clear();
		for (size_t i = 0; i < q.size; i++)
		{
			(*this).AddLast(curPtr->value);
			curPtr = curPtr->next;
		}
		return *this;
	}

	LinkedList operator+(const LinkedList& q)
	{
		LinkedList p;								 //Копия в новой области памяти
		Node* curPtr = head;
		for (size_t i = 0; i < size; i++)
		{
			p.AddLast(curPtr->value);
			curPtr = curPtr->next;
		}

		curPtr = q.head;
		for (size_t i = 0; i < q.size; i++)
		{
			p.AddLast(curPtr->value);
			curPtr = curPtr->next;
		}
		return p;
	}

	bool operator==(const LinkedList& q)
	{
		if (size != q.size) return false;
		Node* curPtr = head;
		Node* qPtr = q.head;
		int i = 0, k = 0;
		while (i < q.size)
		{
			if (curPtr->value == qPtr->value) k++;
			curPtr = curPtr->next;
			qPtr = qPtr->next;
			i++;
		}
		return (k == q.size);
	}

	bool operator!=(const LinkedList& q)
	{
		if (size == q.size) return false;
		Node* curPtr = head;
		Node* qPtr = q.head;
		int i = 0, k = 0;
		while (i < q.size)
		{
			if (curPtr->value != qPtr->value) k++;
			curPtr = curPtr->next;
			qPtr = qPtr->next;
			i++;
		}
		return (k != q.size);
	}

	friend ostream& operator << (ostream& output, LinkedList& p)
	{
		Node* curPtr = p.head;
		for (int i = 0; i < p.size; i++)
		{
			cout << curPtr->value << " ";
			curPtr = curPtr->next;
		}
		return output;
	}

	friend istream& operator >> (istream& input, LinkedList& p)
	{
		string value;
		cout << "\n\t\t\t\tВведите новый элемент: "; getline(input >> ws, value);
		p.AddLast(value);
		return input;
	}

	bool IsListEmpty()
	{
		return head == nullptr;
	}

	void CutNode(Node* node, Node* previous = nullptr) //Удалить узел node, учтя предыдущий узел previous
	{
		if (node == nullptr) return;
		if (previous != nullptr)
			previous->next = node->next;
		else
			head = node->next;
		delete node;
	}

	bool CutFromPos(int pos)	//Удалить с позиции pos, в случае успешного удаления вернёт true
	{
		if (pos > size)
			return false;
		if (pos == 0)
			CutNode(head);
		else
		{
			Node* current = GetNode(pos);
			Node* previous = GetNode(pos - 1);
			if (previous == nullptr)
				return false;
			CutNode(current, previous);
		}
		size--;
		return true;
	}

	string GetValue(int index)
	{
		return GetNode(index)->value;
	}

	Node* GetNode(int index)			//Вернёт узел по индексу
	{
		if (index >= size)
			return nullptr;
		Node* current = head;
		int i = 0;
		while (current != nullptr && i < index)
		{
			current = current->next;
			i++;
		}
		return current;
	}

	void AddPos(int pos, string element)	//Добавить элемент на указанную позицию
	{
		if (size == 0)
			head = new Node(element);
		else
		{
			if (pos == 0)
				head = new Node(element, head);
			else
			{
				Node* current = GetNode(pos - 1);
				current->next = new Node(element, current->next);
			}
		}
		size++;
	}

	Node* GetIntoPos(int pos)
	{
		int i = 0;
		Node* ptr = head;
		while (i < pos)
		{
			ptr = ptr->next;
			i++;
		}
		return ptr;
	}

	void AddLast(string element)		//Добавить элемент в конец списка
	{
		AddPos(size, element);
	}

	void AddFirst(string element)		//Добавить элемент в начало списка
	{
		AddPos(0, element);
	}

	int CountNode()
	{
		return size;
	}

	void Print()
	{
		cout << "\n\t\t\t\tСписок:\n";
		int i = 0;
		Node* current = head;
		while (current != nullptr)
		{
			i++;
			cout << "\t\t\t\t" << i << ". " << current->value << "\n";
			current = current->next; 
		}
	}

	void Clear()
	{
		while (CutFromPos(size - 1));
	}

	~LinkedList()
	{
		cout << "вызван деструктор\n";
		Node* curPtr = head;
		Node* nextPtr;
		for (size_t i = 0; i < size; i++)
		{
			nextPtr = curPtr->next;
			delete curPtr;
			curPtr = nextPtr;
		}
	}
};


