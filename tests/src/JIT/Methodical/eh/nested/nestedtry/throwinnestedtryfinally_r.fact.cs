using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nestedtry_throwinnestedtryfinally_r_throwinnestedtryfinally_r_
    {
        [Fact]
        public void _eh_nested_nestedtry_throwinnestedtryfinally_r_throwinnestedtryfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\throwinnestedtryfinally_r\\throwinnestedtryfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
