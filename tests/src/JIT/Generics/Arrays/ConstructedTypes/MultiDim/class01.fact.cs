using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Arrays_ConstructedTypes_MultiDim_class01_class01_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_ConstructedTypes_MultiDim_class01_class01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Arrays\\ConstructedTypes\\MultiDim\\class01\\class01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
