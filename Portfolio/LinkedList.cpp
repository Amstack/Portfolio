/*
CSC350 Lab #7 pt. 2
10-6-17
Alex Stack
*/

#include <iostream>
#include <stdio.h>

using namespace std;

struct node
{
	int data;
	node *next;
};

class List
{
public:
	node *head, *tail;
	List()
	{
		head = NULL;
		tail = NULL;
	}

	void createNode(int val)
	{
		node *temp = new node;
		temp->data = val;
		temp->next = NULL;
		if (head == NULL)
		{
			head = temp;
			tail = temp;
			temp = NULL;
		}
		else
		{
			tail->next = temp;
			tail = temp;
		}
	}

	void display()
	{
		node *temp = new node;
		temp = head;
		while (temp != NULL)
		{
			cout << temp->data << "\t";
		}
	}

	void insertStart(int val)
	{
		node *temp = new node;
		temp->data = val;
		temp->next = head;
		head = temp;
	}

	void insertPos(int val, int pos)
	{
		node *pre = new node;
		node *cur = new node;
		node *temp = new node;
		cur = head;
		for (int i = 1; i < pos; i++)
		{
			pre = cur;
			cur = cur->next;
		}
		temp->data = val;
		pre->next = temp;
		temp->next = cur;
	}

	void deletePos(int n)
	{
		node *cur = new node;
		node *prev = new node;
		cur = head;

		for (int i = 1; i < n; i++)
		{
			prev = cur;
			cur = cur->next;
		}

		prev->next = cur->next;
	}
};

int main()
{
	//Read file, you'll need to change the file location
	FILE * fp;
	fp = fopen("C:\\Users\\Amsta\\Desktop\\test.txt", "r");

	if (fp == NULL) cout << "File could not be opened.\n";

	int i, n = 0, size = 7;
	int r[7];

	while (!feof(fp)) {
		fscanf(fp, "%d", &i);
		r[n] = i;
		n++;
	}

	//Linked List implementation
	List list;

	cout << "The list before deleted even numbers: ";
	for (int j = 0; j < size; j++)
	{
		cout << r[j] << " ";
		list.createNode(j);
	}
	cout << "\n";

	//Remove even location nodes
	for (int j = 0; j < size; j++)
	{
		if (j % 2 == 0)
		{
			list.deletePos(j);
		}
	}

	node cur = *list.head;
	cout << "The list after deleted even numbers: ";
	while (true)
	{
		cout << cur.data << " ";
		if (cur.next != NULL) cur = *cur.next;
		else break;
	}

	return 0;
}
