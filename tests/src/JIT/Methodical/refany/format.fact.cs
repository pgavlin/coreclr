using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany_format_format_
    {
        [OuterLoop]
        [Fact]
        public void _refany_format_format_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\format\\format.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
