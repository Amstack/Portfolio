/*
	CSC350 Lab #4 Alex Stack
*/

#include <iostream>
#include <time.h>
#include <stdio.h>
#include <cstdlib>
using namespace std;

void swap(int ar[], int i, int j)
{
	int temp = ar[i];
	ar[i] = ar[j];
	ar[j] = temp;
}

int partition(int ar[], int low, int high)
{
	int pivot = ar[high];
	int i = (low - 1);
	
	for(int j=low; j<=high-1;j++)
	{
		if(ar[j]<=pivot)
		{
			i++;
			swap(ar,i,j);
		}
	}
	swap(ar, i+1, high);
	return(i+1);
}

void quickSort(int ar[], int low, int high)
{
	if(low < high)
	{
		int part = partition(ar, low, high);
		
		quickSort(ar, low, part - 1);
		quickSort(ar, part + 1, high);
	}
}

void insertionSort(int r[], int n)
{
	int key, j;
	
	for(int i = 2; i < n; i++) {
		key = r[i];
		j = i - 1;
		
		do{
			r[j + 1] =  r[j];
			j = j - 1;
			
		} while(j >= 0 && r[j] > key);
		
		r[j + 1] = key;
	}
}

void merge(int ar[], int l, int m, int r)
{
	int i, j, k;
	int n1 = m - l + 1;
	int n2 = r - m;
	
	int L[n1], R[n2];
	
	for(i=0; i<n1; i++)
	{
		L[i] = ar[l + i];
	}
	for(j=0; j<n2; j++)
	{
		R[j] = ar[m + 1 + j];
	}
	
	i = 0;
	j = 0;
	k = l;
	
	while(i<n1 && j<n2)
	{
		if(L[i] <= R[j])
		{
			ar[k] = L[i];
			i++;
		}
		else
		{
			ar[k] = R[j];
			j++;
		}
		k++;
	}
	
	while(i < n1)
	{
		ar[k] = L[i];
		i++;
		k++;
	}
	
	while(j < n2)
	{
		ar[k] = R[j];
		j++;
		k++;
	}
}

void mergeSort(int ar[], int l, int r)
{
	if(l < r)
	{
		int m = l+(r-l)/2;
		
		mergeSort(ar, l, m);
		mergeSort(ar, m+1, r);
		
		merge(ar, l, m, r);
	}
}

void printArray(int ar[], int size)
{
	for(int i=0;i<size;i++)
	{
		cout << ar[i] << " ";
	}
	cout << "\n";
}

void populate(int r[], int size)
{
	for(int i=0; i<size; i++)
	{
		r[i] = (rand()%100)+1;
	}
}

int main()
{
	int size = 100000;
	
	cout << "Testing time for sorting array of size " << size << ".\n\n";
	
	//Insertion Sort
	int ar[size];
	populate(ar,size);
	
	cout << "Testing running time of Insertion Sort..." << "\n";
	clock_t start = clock();
	insertionSort(ar,size);
	clock_t end = clock();
	double time = (double)(end-start);
	cout << "Done. Insertion Sort performed in " << time << " ms.\n\n";
	
	//Merge sort
	populate(ar,size);
	
	cout << "Testing running time of Merge Sort..." << "\n";
	start = clock();
	mergeSort(ar,0,size-1);
	end = clock();
	time = (double)(end-start);
	cout << "Done. Merge Sort performed in " << time << " ms.\n\n";
	
	//Quick Sort
	populate(ar,size);
	
	cout << "Testing running time of Quick Sort..." << "\n";
	start = clock();
	quickSort(ar,0,size-1);
	end = clock();
	time = (double)(end-start);
	cout << "Done. Quick Sort performed in " << time << " ms.\n\n";
	
	
	return 0;
}
