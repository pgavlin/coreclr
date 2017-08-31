using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinally_50_do_throwinfinally_50_do_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinally_50_do_throwinfinally_50_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinally_50_do\\throwinfinally_50_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
