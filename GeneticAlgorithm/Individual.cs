using System;

public class Individual
{
    public int x { get; set; }//基因
    public int y { get; set; }
    public int z { get; set; }
    public int age { get; set; }
    public double solution { get; set; }

    public Individual(int xx, int yy, int zz)
    {
        this.x = xx;
        this.y = yy;
        this.z = zz;
    }

    public Individual()
    {

    }
}
