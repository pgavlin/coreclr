using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Arrays_TypeParameters_Jagged_class01_class01_
    {
        [Fact]
        public void _Arrays_TypeParameters_Jagged_class01_class01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Arrays\\TypeParameters\\Jagged\\class01\\class01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
