//输入10个数,存入数组a中,求最小值并输出. 
main(){ 
int i; 
float a[10],min; 
scanf("%f",&a[0]); 
min=a[0]; 
for(i=1;i<10;i++){ 
scanf("%f",&a[i]); 
if(a[i]<min) { 
min=a[i];} 
} 
printf("\nmin=%.0f",min); 
}