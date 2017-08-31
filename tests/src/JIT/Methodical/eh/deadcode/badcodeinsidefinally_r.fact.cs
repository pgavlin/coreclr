using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_badcodeinsidefinally_r_badcodeinsidefinally_r_
    {
        [Fact]
        public void _eh_deadcode_badcodeinsidefinally_r_badcodeinsidefinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeinsidefinally_r\\badcodeinsidefinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
