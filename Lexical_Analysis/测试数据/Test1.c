//输入n(n<10),再输入n个数,求最小值 
main(){ 
int i,n; 
float f,min; 
printf("input n(<10):"); 
scanf("%d",&n); 
scanf("%f",&min); 
for(i=1;i<n;i++){ 
scanf("%f",&f); 
if(f<min) min=f;} 
printf("\nmin=%.0f",min); 
} 