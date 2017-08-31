using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_huge_struct_huge_struct_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_huge_struct_huge_struct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\huge_struct\\huge_struct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
