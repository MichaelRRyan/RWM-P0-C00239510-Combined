public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return ModuloFirst.moduloFirst(CubeFilter.cubes(xs));
    }
}
