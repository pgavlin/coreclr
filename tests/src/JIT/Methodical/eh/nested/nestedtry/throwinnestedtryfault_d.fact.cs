using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nestedtry_throwinnestedtryfault_d_throwinnestedtryfault_d_
    {
        [Fact]
        public void _eh_nested_nestedtry_throwinnestedtryfault_d_throwinnestedtryfault_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nestedtry\\throwinnestedtryfault_d\\throwinnestedtryfault_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
