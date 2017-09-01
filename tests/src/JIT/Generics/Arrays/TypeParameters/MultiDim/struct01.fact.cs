using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Arrays_TypeParameters_MultiDim_struct01_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_TypeParameters_MultiDim_struct01_struct01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Arrays\\TypeParameters\\MultiDim\\struct01\\struct01.cmd");
        }
    }
}
