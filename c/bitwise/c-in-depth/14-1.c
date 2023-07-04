#include <stdio.h>
#include "common.c"

int main(void)
{
    int a, b;
    printf("Enter values of a and b in hexadecimal: ");
    scanf("%x%x", &a, &b);

    printf("a=%X\n", a);
    displayBits(a);

    printf("b=%x\n", b);
    displayBits(b);

    printf("a&b=%X\n", a&b);
}