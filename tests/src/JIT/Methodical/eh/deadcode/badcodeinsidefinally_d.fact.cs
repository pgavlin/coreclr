using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_badcodeinsidefinally_d_badcodeinsidefinally_d_
    {
        [Fact]
        public void _eh_deadcode_badcodeinsidefinally_d_badcodeinsidefinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeinsidefinally_d\\badcodeinsidefinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
