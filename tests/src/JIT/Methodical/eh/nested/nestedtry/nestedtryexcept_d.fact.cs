using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nestedtry_nestedtryexcept_d_nestedtryexcept_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_nestedtryexcept_d_nestedtryexcept_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\nestedtryexcept_d\\nestedtryexcept_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
