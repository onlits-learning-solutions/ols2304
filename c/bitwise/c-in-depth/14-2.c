#include <stdio.h>
#include "common.c"

int main(void)
{
    int a = 7;
    printf("a=%d\t", a);
    displayBits(a);
    a = a << 2;
    printf("a=%d\t", a);
    displayBits(a);

    a = a << 3;
    printf("a=%d\t", a);
    displayBits(a);
    
    a = a >> 1;
    printf("a=%d\t", a);
    displayBits(a);
    
    a = a >> 3;
    printf("a=%d\t", a);
    displayBits(a);
    return 0;
}