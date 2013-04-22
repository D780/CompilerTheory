/*写一个函数,统计或判断通过键盘输入的字符串中的字母.
要求在主函数中输入、输出字符串以及其中的字母个数.
*/
main() 
{char a[200]; 
int k=0,i=0; 
printf("input :"); 
do{ scanf("%c",&a[i]); 
if(('a'<=a[i]&&a[i]<='z')||('A'<=a[i]&&a[i]<='Z'))k++; 
i++; 
} while(a[i-1]!='\n'); 
a[i]='\0'; 
printf("\n%s\n%d chars",a,k); 
}