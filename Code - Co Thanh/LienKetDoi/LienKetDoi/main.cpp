#include <iostream>
#include<fstream>
#include<conio.h>
#include<math.h>
using namespace std;

ifstream input("input.txt");
ofstream output("output.txt");

struct Node
{
	int data;
	struct Node* Next;
	struct Node* Prev;
};
typedef struct Node NODE;

struct List
{
	NODE* Head = NULL, * Tail = NULL;
};
typedef struct List LIST;

NODE *GetNode(int x) {
	NODE* p=new NODE;
	if (p == NULL) {
		cout << "Khong du dung luong de tao Node";
		return NULL;
	}
	p->data = x;
	p->Next = NULL;
	p->Prev = NULL;
	return p;
}

void AddHead(LIST& l, NODE* p) {
	if (l.Head == NULL) {
		l.Head = l.Tail = p;
	}
	else {
		p->Next = l.Head;
		l.Head->Prev = p;
		l.Head = p;
	}
}

void AddTail(LIST& l, NODE* p) {
	if (l.Head == NULL) {
		l.Head = l.Tail = p;
	}
	else {
		l.Tail->Next = p;
		p->Prev = l.Tail;
		l.Tail = p;
	}
}

void Input(LIST& l) {
	int a[100];
	int n;
	input >> n;
	for (int i = 0; i < n; i++) {
		input >> a[i];
		NODE* p = GetNode(a[i]);
		AddTail(l, p);
	}
	cout << "Nhap file thanh cong";
}

void OutPut(LIST l) {
	for (NODE *p=l.Head; p!=NULL ; p=p->Next)
	{
		output << p->data<<" ";
	}
	cout << "\n";
	output << "\n";
}

