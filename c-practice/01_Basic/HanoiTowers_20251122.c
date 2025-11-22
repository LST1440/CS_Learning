#include <stdio.h>

int count =0;

void hanoi(int n,char from,char temp,char to){
    if(n==1){
        count++;
        printf("將盤子1從%c移到%c\n",from,to);
        return;
    }

    //不等於1的情況下
    //起點搬到暫存
    hanoi(n-1,from,to,temp);
    count++;
    //最後一個搬到終點
    printf("將盤子%d從%c移到%c\n",n,from,to);

    //暫存的搬到終點
    hanoi(n-1,temp,from,to);
}

int main(void){
    int n;
    printf("請輸入河內塔的盤子數量:");
    scanf("%d",&n);

    printf("\n<開始搬運%d個盤子>\n",n);

    count=0;

    hanoi(n,'A','B','C');
    printf("搬運完成，共使用了%d個步驟!",count);

    return 0;
}