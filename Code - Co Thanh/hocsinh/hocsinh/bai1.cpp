#include "stdio.h"
#include "conio.h"
#include "time.h"
#include "Windows.h"
#include <iostream>
#include <iomanip>
#include <string>
using namespace std;


struct HocSinh
{
	string HoTen;
	int NamSinh;
	int GioiTinh;
	float DiemToan;
	float DiemVan;
	float DiemAnh;
	float DiemTB;
};
typedef struct HocSinh HOCSINH;

struct Node
{
	HOCSINH data;
	struct Node* Next;
};
typedef struct Node NODE;

struct List {
	NODE* Head = NULL;
	NODE* Tail = NULL;
};
typedef struct List LIST;

NODE* getNode(HOCSINH x) {
	NODE* p;
	p = new NODE;
	if (p == NULL)
		return NULL;
	p->data = x;
	p->Next = NULL;
	return p;
}

void InPutData(HOCSINH& x) {
	cin.ignore();
	cout << "Nhap ten hoc sinh: ";
	getline(cin, x.HoTen);

	do {
		cout << "Nhap nam sinh hoc sinh: ";
		cin >> x.NamSinh;
		if (x.NamSinh <= 0 || x.NamSinh > 2024) {
			cout << "Nam sinh khong hop le!" << endl;
		}
	} while (x.NamSinh <= 0 || x.NamSinh > 2024);

	do {
		cout << "Nhap gioi tinh hoc sinh [0.Nam/1.Nu]: ";
		cin >> x.GioiTinh;
		if (x.GioiTinh != 1 && x.GioiTinh != 0) {
			cout << "Gioi tinh khong hop le! [0.Nam/1.Nu]" << endl;
		}
	} while (x.GioiTinh != 1 && x.GioiTinh != 0);

	do {
		cout << "Nhap diem toan hoc sinh: ";
		cin >> x.DiemToan;
		if (x.DiemToan < 0 || x.DiemToan > 10) {
			cout << "Diem toan khong hop le!" << endl;
		}
	} while (x.DiemToan < 0 || x.DiemToan > 10);

	do {
		cout << "Nhap diem van hoc sinh: ";
		cin >> x.DiemVan;
		if (x.DiemVan < 0 || x.DiemVan > 10) {
			cout << "Diem van khong hop le!" << endl;
		}
	} while (x.DiemVan < 0 || x.DiemVan > 10);

	do {
		cout << "Nhap diem anh hoc sinh: ";
		cin >> x.DiemAnh;
		if (x.DiemAnh < 0 || x.DiemAnh > 10) {
			cout << "Diem anh khong hop le!" << endl;
		}
	} while (x.DiemAnh < 0 || x.DiemAnh > 10);

	x.DiemTB = (x.DiemToan + x.DiemVan + x.DiemAnh) / 3;

}

void AddHead(LIST& l, NODE* newNode) {
	if (l.Head == NULL) {
		l.Head = newNode;
		l.Tail = newNode;
	}
	else
	{
		newNode->Next = l.Head;
		l.Head = newNode;
	}
}

void AddHeadFunction(LIST& l) {
	HOCSINH x;
	InPutData(x);
	NODE* p = getNode(x);
	AddHead(l, p);
	cout << "\n";
}

void AddTail(LIST& l, NODE* newNode) {
	if (l.Head == NULL) {
		l.Head = newNode;
		l.Tail = newNode;
	}
	else
	{
		l.Tail->Next = newNode;
		l.Tail = newNode;
	}
}

void AddTailFunction(LIST& l) {
	HOCSINH x;
	InPutData(x);
	NODE* p = getNode(x);
	AddTail(l, p);
	cout << "\n";
}


void Input(LIST& l) {
	int n;
quaylai:
	cout << "Moi ban nhap so luong hoc sinh: ";
	cin >> n;
	if (n <= 0) {
		cout << "So luong hoc sinh khong hop le";
		goto quaylai;
	}

	for (int i = 0; i < n; i++)
	{
		HOCSINH x;
		InPutData(x);
		NODE* p = getNode(x);
		AddTail(l, p);
		cout << "\n";
	}
}

void Out(NODE* p) {
	cout << "Ho Ten: " << p->data.HoTen << endl;;
	cout << "Nam Sinh: " << p->data.NamSinh;;
	cout << "Gioi Tinh: ";
	if (p->data.GioiTinh == 0) {
		cout << "Nam" <<endl;
	}
	else {
		cout << "Nu" << endl;
	}
	cout << "Toan: " << p->data.DiemToan << endl;
	cout << "Van: " << p->data.DiemVan << endl;
	cout << "Anh: " << p->data.DiemAnh << endl;
	cout << "DiemTB: " <<p->data.DiemTB<< "\n\n";
}

void OutPut(LIST l) {
	int count = 1;
	for (NODE* p = l.Head; p != NULL; p = p->Next) {
		cout << "Xuat hoc sinh thu " << count << ":\n";
		Out(p);
		count++;
	}
}


void staffOver18Year(LIST l) {
	NODE* p;
	int count = 0;
	for (p = l.Head; p != NULL; p = p->Next) {
		if (2024 - p->data.NamSinh >=18)
		{
			Out(p);
		}
		count++;
	}
	if (count == 0) {
		cout << "Khong co hoc sinh nao tren 18 tuoi";
	}
}

void CountDiemTBTren5(LIST& l)
{
	NODE* p;
	int count = 0;
	for (p = l.Head; p != NULL; p = p->Next)
	{
		if (p->data.DiemTB > 5)
		{
			count++;
		}
	}
	if (count > 0)
	{
		cout << "So hoc sinh co diem TB tren 5 la:" << count << endl;
	}
	else
	{
		cout << "Khong co hoc sinh co diem TB tren 5" << endl;
	}
}


void SortUpYearsOld(LIST& l)
{
	NODE* p, * q;

	for (p = l.Head; p != l.Tail; p = p->Next)
	{
		for (q = p->Next; q != NULL; q = q->Next)
		{
			HOCSINH tmp = p->data;
			p->data = q->data;
			q->data = tmp;
		}
	}
	cout << "\n";
	OutPut(l);
}


void MENU() {
	cout << "\n========= Menu ==========" << endl;
	cout << "0. Thoat." << endl;
	cout << "1. Xuat danh sach hoc sinh." << endl;
	cout << "2. Them 1 hoc sinh dau danh sach." << endl;
	cout << "3. Them 1 hoc sinh cuoi danh sach." << endl;
	cout << "4. Liet ke cac hoc sinh tren 18 tuoi. " << endl;
	cout << "5. Dem so luong nhan vien co diem trung binh tren 5. " << endl;
	cout << "6. Sap xep giam dan theo nam sinh. \n" << endl;
}

int main() {
	LIST l;
	int choose;
	;	Input(l);
	do {
		MENU();
		cout << "Ban chon: ";
		cin >> choose;

		switch (choose) {
		case 0:
		{
			cout << "\nThoat" << endl;
			break;
		}
		case 1: {
			cout << "XUAT DANH SACH CAC HOC SINH :\n " << endl;
			OutPut(l);
			break;
		}
		case 2: {
			AddHeadFunction(l);
			break;
		}
		case 3: {
			AddTailFunction(l);
			break;
		}
		case 4: {
			cout << "\nXuat danh sach hoc sinh tren 18 tuoi: " << endl;
			staffOver18Year(l);
			break;
		}
		case 5: {
			cout << "\nXuat so luong nhan vien co diem trung binh tren 5: " << endl;
			CountDiemTBTren5(l);
			break;
		}
		case 6: {
			cout << "\nSap xep giam dan theo nam sinh: " << endl;
			SortUpYearsOld(l);
			break;
		}
		default: {
			cout << "Hien tai chua co lua chon ban da chon" << endl;
		}
		}
	} while (choose != 0);




	return 0;
}