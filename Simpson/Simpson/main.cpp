#include <iostream>
#include <math.h>
using namespace std;
 
double f(double x)
{
	return sin(x*x+2*x);	
}
 
int main() 
{
system("chcp 1251");
	double a, b, eps;//������ � ������� ������� �������������� (a, b), ����������� (eps).
	cin >> a >> b >> eps;
	double I=eps+1, I1=0;//I-���������� ����������� �������� ���������, I1-�����, � ������� N.
	for (int N=2; (N<=4)||(fabs(I1-I)>eps); N*=2)
	{
		double h, sum2=0, sum4=0, sum=0;
		h=(b-a)/(2*N);//��� ��������������.
		for (int i=1; i<=2*N-1; i+=2)
		{   
			sum4+=f(a+h*i);//�������� � ��������� ���������, ������� ����� �������� �� 4.
			sum2+=f(a+h*(i+1));//�������� � ������� ���������, ������� ����� �������� �� 2.
		}
		sum=f(a)+4*sum4+2*sum2-f(b);//�������� �������� f(b) ��� ��� ����� ��������� ��� ������. 
		I=I1;
		I1=(h/3)*sum;
	}
	cout << I1 << endl;
	system("pause");
	return 0;
}