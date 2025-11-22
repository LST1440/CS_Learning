#include <stdio.h>

int fib_recursive(int n);
int fib_iterative(int n);

int main(void){
    int n;

    printf("<費式數列測試程式>\n");
    printf("請輸入要計算項次(n):");
    scanf("%d",&n);

    if(n<0){ //防呆
        printf("請輸入大於等於0的整數\n");
        return 0;
    }

    //測試迴圈版
    int result_iter=fib_iterative(n);
    printf("\n[迴圈版 Iterative] Fib(%d) = %d\n",n,result_iter);

    //測試遞迴版
    printf("\n[遞迴版 Recursive] 計算中...(如果卡住請稍等)\n");
    int result_rec=fib_recursive(n);
    printf("[遞迴版 Rescursive] Fib(%d) = %d\n",n,result_rec);

    return 0;
}

int fib_recursive(int n){
    if(n<=1){
        return n;
    }

    return fib_recursive(n-1)+fib_recursive(n-2);
}

int fib_iterative(int n){
    if(n==0) return 0;
    if(n==1) return 1;

    int i;
    int a=0;
    int b=1;
    int sum;

    for(i=2;i<=n;i++){
        sum=a+b;

        a=b;
        b=sum;
    }

    return sum;
}
