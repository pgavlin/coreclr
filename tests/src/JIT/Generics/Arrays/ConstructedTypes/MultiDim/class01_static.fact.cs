using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Arrays_ConstructedTypes_MultiDim_class01_static_class01_static_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_ConstructedTypes_MultiDim_class01_static_class01_static_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Arrays\\ConstructedTypes\\MultiDim\\class01_static\\class01_static.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
