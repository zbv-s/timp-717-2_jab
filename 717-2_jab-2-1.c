#include <stdio.h>
int main()
{
int a, b, c = 0;
scanf("%d%d", &a, &b);
for (int i = a; i <= b; c += i, ++i);
printf("%d\n", c);
return 0;
}
