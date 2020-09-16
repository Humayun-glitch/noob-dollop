#include <iostream>
#include <string>
using namespace std;

class mypc{
    public:
    
    string myprocessor;
    string myram;
    string mymobo;
    string mygpu;
};

int main(){
    
    //Defined the object as 'obj'
    
	mypc obj;
	
	//for input of the specs
	
    cout<<"Enter Processor Model : "<<endl;
    getline(cin,obj.myprocessor);
    cout<<"\nEnter RAM Size and Model : "<<endl;
    getline(cin,obj.myram);
    cout<<"\nEnter Motherboard Model : "<<endl;
    getline(cin,obj.mymobo);
    cout<<"\nEnter GPU Model : "<<endl;
    getline(cin,obj.mygpu);
    
    //displaying the specs
    
    cout<<"\nMy PC's Processor Model is : "<<obj.myprocessor<<endl;
    cout<<"\nMy PC's RAM is : "<<obj.myram<<endl;
    cout<<"\nMy PC's MotherBoard Model is : "<<obj.mymobo<<endl;
    cout<<"\nMy PC's GPU is : "<<obj.mygpu<<endl;
    return 0;
}

