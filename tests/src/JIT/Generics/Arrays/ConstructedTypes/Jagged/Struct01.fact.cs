using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Arrays_ConstructedTypes_Jagged_Struct01_Struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_ConstructedTypes_Jagged_Struct01_Struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Arrays\\ConstructedTypes\\Jagged\\Struct01\\Struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
