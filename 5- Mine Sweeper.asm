include Irvine32.inc
includelib Irvine32.lib
.stack 100h
.data
board byte 36 dup('0'),0
copy byte 36 dup('-'),0
str0 byte "Bomb Position List: ", 0
str1 byte "****************Minesweeper******************",0
str2 byte "Enter Box Number[0-35]: ",0
str3 byte "****************Game Over******************",0
str4 byte "Instructions!",0
str5 byte "0. 0 Represents No Bomb Is Present NearBy", 0
str6 byte "1. 1 Represents A Bomb Is Near By",0
.code

printSpaceAndComma proc
mov al, ','
call writechar
mov al, ' '
call writechar
ret
printSpaceAndComma endp

Intro proc
call crlf
mov eax, 1
call addColors
mov edx, offset str1
call writestring
call crlf
mov eax, 4
call addColors
mov edx, offset str4
call writestring
call crlf
mov edx, offset str5
call writestring
call crlf
mov edx, offset str6
call writestring
call crlf
mov eax, 0 ;restting color back to white
call addColors
ret
Intro endp

Display proc
mov eax, 2
call addColors
mov edx, offset str2
call writestring
call readdec
call clrscr ; Not known
mov edx,eax
mov esi,0
mov ecx, 36
l1:
mov al, ' '
call writechar
cmp edx,esi
jne n
m:
mov ebx,esi
mov al,board[esi]
mov copy[esi],al
call writechar
jmp t
n:
mov al,copy[esi]
call writechar
t:
mov al, ' '
call writechar
inc esi
cmp cl, 31
jz crl
cmp cl, 25
jz crl
cmp cl, 19
jz crl
cmp cl, 13
jz crl
cmp cl, 7
jz crl
jmp next
crl:
call crlf
call crlf
jnz next
next:
loop l1
call crlf
ret
Display endp 

addColors proc
cmp eax, 0
je whiteColor
cmp eax, 1
je greenColor
cmp eax, 2
je cyanColor
cmp eax, 3
je redColor
cmp eax, 4
je yellowColor
cmp eax, 5
je magentaColor

jmp endPoint

whiteColor:
mov eax, white
call settextcolor
jmp endPoint

greenColor:
mov eax, green
call settextcolor
jmp endPoint

cyanColor:
mov eax, cyan
call settextcolor
jmp endPoint

redColor:
mov eax, red
call settextcolor
jmp endPoint

yellowColor:
mov eax, yellow
call settextcolor
jmp endPoint

magentaColor:
mov eax, lightmagenta
call settextcolor
jmp endPoint


endPoint:
;pop eax
ret
addColors endp


midPortion proc
mov eax,esi
mov board[esi],'*'
sub esi,1
add board[esi],1
sub esi,4
add board[esi],1
sub esi,1
add board[esi],1
sub esi,1
add board[esi],1
add esi,8
add board[esi],1
add esi,4
add board[esi],1
add esi,1
add board[esi],1
add esi,1
add board[esi],1
mov esi,eax
ret
midPortion endp



leftRightTraverse proc
mov eax,esi
cmp esi,6
je left
cmp esi,12
je left
cmp esi,18
je left
cmp esi,24
je left
cmp esi,11
je right
cmp esi,17
je right
cmp esi,23
je right
cmp esi,29
je right
inc edx
jmp endPoint

left:
mov board[esi],'*'
sub esi,5
add board[esi],1
sub esi,1
add board[esi],1
add esi,7
add board[esi],1
add esi,5
add board[esi],1
add esi,1
add board[esi],1
jmp endPoint



right:
mov board[esi],'*'
sub esi,1
add board[esi],1
sub esi,5
add board[esi],1
sub esi,1
add board[esi],1
add esi,12
add board[esi],1
add esi,1
add board[esi],1
jmp endPoint

endPoint:
mov esi,eax
ret
leftRightTraverse endp



mazeCorners proc
mov eax,esi
cmp esi,0
je left1
cmp esi,5
je right1
cmp esi,30
je left2
cmp esi,35
je right2
cmp edx,1
inc edx
jmp endPoint

left1:
mov board[esi],'*'
add esi,1
add board[esi],1
add esi,5
add board[esi],1
add esi,1
add board[esi],1
jmp endPoint

right1:
mov board[esi],'*'
sub esi,1
add board[esi],1
add esi,6
add board[esi],1
add esi,1
add board[esi],1
jmp endPoint

left2:
mov board[esi],'*'
add esi,1
add board[esi],1
sub esi,6
add board[esi],1
sub esi,1
add board[esi],1
jmp endPoint

right2:
mov board[esi],'*'
sub esi,1
add board[esi],1
sub esi,5
add board[esi],1
sub esi,1
add board[esi],1
jmp endPoint

endPoint:
mov esi,eax
ret
mazeCorners endp

boundary proc
mov eax,esi
cmp esi,1
je topBoundary
cmp esi,2
je topBoundary
cmp esi,3
je topBoundary
cmp esi,4
je topBoundary
cmp esi,31
je downBoundary
cmp esi,32
je downBoundary
cmp esi,33
je downBoundary
cmp esi,34
je downBoundary
cmp edx,1
inc edx
jmp endPoint

topBoundary:
mov board[esi],'*'
sub esi,1
add board[esi],1
add esi,2
add board[esi],1
add esi,4
add board[esi],1
add esi,1
add board[esi],1
add esi,1
add board[esi],1
jmp endPoint

downBoundary:
mov board[esi],'*'
add esi,1
add board[esi],1
sub esi,2
add board[esi],1
sub esi,4
add board[esi],1
sub esi,1
add board[esi],1
sub esi,1
add board[esi],1
jmp endPoint

endPoint:
mov esi,eax
ret
boundary endp



main proc
mov esi,0
mov ecx,4
mov ebx,ecx
mov eax, 5
call addColors
mov edx, offset str0
call writestring
call Randomize
l1:
mov eax,35
call RandomRange
call writedec
call printSpaceAndComma
mov edx,0
cmp board[eax],'0'
jne invalid
mov esi,eax
call leftRightTraverse 
call mazeCorners
call boundary
cmp edx,3
jl e
call midPortion
e:
invalid:
mov ecx,ebx
dec ebx
loop l1
j1:
call Intro
call Display
cmp board[ebx],'*'
je k
jmp j1
k:
call Intro
mov ecx,36
mov esi,0
l2:
mov al, ','
call writechar
cmp board[esi],'*'
jne n
m:
mov al,board[esi]
mov copy[esi],al
call writechar
jmp t
n:
mov al,copy[esi]
call writechar
t:
mov al, ','
call writechar
inc esi
cmp cl, 31
jz crl
cmp cl, 25
jz crl
cmp cl, 19
jz crl
cmp cl, 13
jz crl
cmp cl, 7
jz crl
jmp next
crl:
call crlf
call crlf
jnz next
next:
loop l2
call crlf

mov eax, 3
call addColors
mov edx, offset str3
call writestring
call crlf
exit
main endp
end main
