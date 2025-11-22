#include <stdio.h>

int horner_recursive(int poly[],int n,int x,int i){
    //終止條件
    if(i==n){
        return poly[i];
    }

    //遞迴步驟
    return poly[i]+x*horner_recursive(poly,n,x,i+1);
}

int main(void){
    int poly[]={7,5,4,2};
    int n=3;
    int x=2;

    int result = horner_recursive(poly,n,x,0);

    printf("The value of polynomial is: %d\n",result);

    return 0;
}