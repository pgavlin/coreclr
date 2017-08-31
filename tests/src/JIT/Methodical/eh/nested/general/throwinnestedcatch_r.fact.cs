using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_throwinnestedcatch_r_throwinnestedcatch_r_
    {
        [Fact]
        public void _eh_nested_general_throwinnestedcatch_r_throwinnestedcatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\throwinnestedcatch_r\\throwinnestedcatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
