section .bss           ;Uninitialized data
   	num resb 5
	res resb 5

section .text
	global _start

section .data
	msg db 'Enter a number: '
	len equ $ - msg
	msg2 db 'You have entered: '
	len2 equ $ - msg2
	msg3 db 'Your number + 5 = '
	len3 equ $ - msg3

_start:
	mov edx,len	;ask user for num
	mov ecx,msg
	mov ebx,1
	mov eax,4
	int 0x80

   	mov eax, 3	;Read and store the user input
   	mov ebx, 2
   	mov ecx, num  
   	mov edx, 5	;5 bytes
   	int 0x80

	mov eax, 4	;Print out 'entered num: '
	mov ebx, 1
   	mov ecx, msg2
   	mov edx, len2
   	int 0x80  

	mov eax, 4	;Output entered number
  	mov ebx, 1
  	mov ecx, num
  	mov edx, 5
  	int 0x80

	mov eax, 4	;Print out 'added num: '
	mov ebx, 1
   	mov ecx, msg3
   	mov edx, len3
   	int 0x80 

	mov eax, '5'	;Add num + 5
	sub eax, '0'
	mov ebx, [num]
	sub ebx, '0'
	add eax, ebx
	add eax, '0'
	mov [res], eax
	
	mov eax, 4	;Output added number
  	mov ebx, 1
  	mov ecx, res
  	mov edx, 5
  	int 0x80

	mov eax,1
	int 0x80
