//输入n(n<10),再输入n个数,输出最小值和它所对应的下标 
main(){ 
int i,n,k=1; 
float f,min; 
printf("input n(<10):"); 
scanf("%d",&n); 
scanf("%f",&min); 
for(i=1;i<n;i++){ 
scanf("%f",&f); 
if(f<min) { 
min=f;k=i+1;} 
} 
printf("\nmin(%d)=%.0f",k,min); 
} 