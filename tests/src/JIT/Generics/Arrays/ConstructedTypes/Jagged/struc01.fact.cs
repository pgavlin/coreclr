using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Arrays_ConstructedTypes_Jagged_struc01_struc01_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_ConstructedTypes_Jagged_struc01_struc01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Arrays\\ConstructedTypes\\Jagged\\struc01\\struc01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
