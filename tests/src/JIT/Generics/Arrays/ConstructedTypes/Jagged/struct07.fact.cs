using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Arrays_ConstructedTypes_Jagged_struct07_struct07_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_ConstructedTypes_Jagged_struct07_struct07_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Arrays\\ConstructedTypes\\Jagged\\struct07\\struct07.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
