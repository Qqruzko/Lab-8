using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Triangle
    {
    public Triangle(int AB,int BC,int CA)
    {
        
        tAB = AB;
        tBC = BC;
        tCA = CA;
    }
    private  int tAB = 0;
    private  int tBC = 0;
    private  int tCA = 0;
    public int pAB()
    {
        return (tAB);
    }
    public int pBC()
    {
        return (tBC);
    }
    public int pCA()
    {
        return (tCA);
    }
    public bool real_triangle(Triangle tri)
    {
        if (tri.pAB() + tri.pBC() < tri.pCA() || tri.pBC() + tri.pCA() < tri.pAB() || tri.pAB() + tri.pBC() < tri.pCA())
        {
            return (false);
            
        }
        else
            if (tri.pAB() + tri.pBC() > tri.pCA() || tri.pBC() + tri.pCA() > tri.pAB() || tri.pAB() + tri.pBC() > tri.pCA())
        {
            return (true);
            
        }
            return (false);

    }
    public int triangle_perimeter(Triangle tri)
    {
        int perimeter = tri.pBC() + tri.pCA() + tri.pCA();
        
        
        return (perimeter);
    }
    public double triangle_space(Triangle tri, int perimeter)
    {
        int p = perimeter / 2;
        double S = Math.Sqrt(p * (p - tri.pAB()) * (p - tri.pBC()) * (p - tri.pCA()));
        return (S);
    }
}

