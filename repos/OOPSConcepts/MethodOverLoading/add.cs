namespace MethodOverLoading
{
    public class add
    {
        public int a;
        public int b;

        public string fName;
        public string lName;

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;


        }
        public string concat(string s,string str)
        {
            return s + str;
        }
        public string concat(string fName,string lName,string s)
        {

        return fName + lName+s; 
        }
    }
    }
}
