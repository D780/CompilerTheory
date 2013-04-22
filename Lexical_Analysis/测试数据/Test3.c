//输入n(n<10),再输入n个数,将它们从小到大排序后再输出 
main(){ 
int a[11]; 
int i,j,t=0; 
printf("input num:"); 
for(i=0;i<10;i++) 
scanf("%d",&a[i]); 
for(i=0;i<10;i++) 
for(j=i+1;j<10;j++) 
if(a[i]>a[j]) { 
t=a[j]; 
a[j]=a[i]; 
a[i]=t; } 
for(i=0;i<10;i++) 
printf("%d ",a[i]); 
} 