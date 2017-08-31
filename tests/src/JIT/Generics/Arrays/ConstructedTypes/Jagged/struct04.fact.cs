using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Arrays_ConstructedTypes_Jagged_struct04_struct04_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_ConstructedTypes_Jagged_struct04_struct04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Arrays\\ConstructedTypes\\Jagged\\struct04\\struct04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
