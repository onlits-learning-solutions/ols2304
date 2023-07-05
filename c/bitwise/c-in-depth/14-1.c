#include <stdio.h>
#include "common.c"

int main(void)
{
    int a, b;
    printf("Enter values of a and b in hexadecimal: ");
    scanf("%x%x", &a, &b);
    putchar('\n');

    printf("a=%X\n", a);
    printf("a=%d\n", a);
    displayBits(a);
    putchar('\n');

    printf("b=%X\n", b);
    printf("b=%d\n", b);
    displayBits(b);
    putchar('\n');

    printf("a&b=%X\n", a&b);
    printf("a&b=%d\n", a&b);
    displayBits(a&b);
    putchar('\n');

    printf("a|b=%X\n", a|b);
    printf("a|b=%d\n", a|b);
    displayBits(a|b);
    putchar('\n');

    printf("a^b=%X\n", a^b);
    printf("a^b=%d\n", a^b);
    displayBits(a^b);
    putchar('\n');

    printf("~a=%X\n", ~a);
    printf("~a=%d\n", ~a);
    displayBits(~a);
    putchar('\n');

    printf("~b=%X\n", ~b);
    printf("~b=%d\n", ~b);
    displayBits(~b);
    putchar('\n');

    printf("~(~a)=%X\n", ~(~a));
    printf("~(~a=)%d\n", ~(~a));
    displayBits(~(~a));
    putchar('\n');

    return 0;
}