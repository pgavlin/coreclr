using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nestedtry_throwinnestedtryexcept_r_throwinnestedtryexcept_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_nestedtry_throwinnestedtryexcept_r_throwinnestedtryexcept_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\throwinnestedtryexcept_r\\throwinnestedtryexcept_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
