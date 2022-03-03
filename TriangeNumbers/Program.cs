
//loop through numbers all the way up to an arbitrarily high integer
//perform equation 'n(n+1)/2' to each number
//loop through every answer's modulous == 0 to find the factors
//add each factor to a list
//create if statement to check if list.count < 500
//break loop statements
//print 


int n = 1;
int j = 1;
int k = 1;
int l = 1;
int m = 1;
int o;


List<int>? areaList = new List<int>();
List<int>? factorList = new List<int>();


for (n = 1; n <= 1000000000; n++)
{
    j = (n * (n + 1) / 2);
    areaList.Add(j); //list contains all possible triangle areas
    for (k = 1; k < areaList.Count; k++)
    {
        m = areaList[k];
        for (l = 1; l <= m; l++)
        {
            if (m % l == 0)
            {
                factorList.Add(m / l);
            }
        }
        if (factorList.Count <= 500)
        {
            factorList.Clear();
        }
        else
        {
            o = factorList.Count - 1;
            Console.WriteLine(factorList[o]);
            break;
        }
    }
}




