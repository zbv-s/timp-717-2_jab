#include<stdio.h>
int main() {
    int left =0, right =0, n;
    char c = 0;
    scanf("%d", &n);
    for(int i=0; i < 2*n; i++){ 
        c=getchar();
        if(c =='(')
        { left++;}
        if(c ==')')  
        {right++;}
        
    }
    if(left == right)
    {printf("%d", 1);}
    else
    {printf("%d", 0);}
}
