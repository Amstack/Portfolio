/*
	CSC 350 Lab #9
	10-20-17
	Alex Stack
*/

#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define KEY_SIZE 10
#define TABLE_SIZE 13

using namespace std;

typedef struct
{
	char *key;
}element;

element hash_table[TABLE_SIZE];

int transform(char *key)
{
	int hash;
	
	while(*key) hash += *key++;
	
	return hash;
}

int hash_function(char *key)
{
	return transform(key) % TABLE_SIZE;
}

#define empty(e) (strlen(e.key) == 0)
#define equal(e1, e2) (!strcmp(e1.key,e2.key))

void hash_lp_add(element item, element ht[])
{
	int i, hash_value;
	hash_value = i = hash_function(item.key);
	
	if(empty(ht[i])) ht[i] = item;
	
	while(!empty(ht[i]))
	{
		if(i == hash_value)
		{
			cout << "Table is full.\n";
			return;
		}
	}
}

void hash_lp_search(element item, element ht[])
{
	int i, hash_value;
	hash_value = i = hash_function(item.key);
	while(!empty(ht[i]))
	{
		//Found value in hash table
		if(equal(item, ht[i]))
		{
			cout << "Search Success: Location " << i << ".\n";
			return;
		}
		
		//Value not found in hash table
		if(!equal(item, ht[i]))
		{
			cout << "No value found in table.\n";
			return;
		}
	}
	cout << "No value found in table.\n";
}

void hash_lp_print(element ht[])
{
	int i = 0;
	while(i < TABLE_SIZE)
	{
		cout << "[" << i << "]\t" << ht[i].key;
	}
}

int main()
{
	element tmp;
	char keyIn;
	int op;
	while(1)
	{
		cout << "===============================\n";
		cout << "Enter the desired operation(0: input, 1: seek, 2: end): ";
		cin >> op;
		cout << "\n";
		if(op == 0)
		{
			cout << "Enter key: ";
			cin >> keyIn;
			cout << "\n";
			tmp.key -> keyIn;
			hash_lp_add(tmp, hash_table);
		}
			
		if(op == 1)
		{
			cout << "Enter search key: "; cin >> keyIn; cout << "\n";
			hash_lp_search(tmp, hash_table);
		}
		
		if(op == 2) break;
		cout << "===============================\n";
	}
	
	return 0;
}
