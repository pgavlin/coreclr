using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_badcodeafterfault_d_badcodeafterfault_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeafterfault_d_badcodeafterfault_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeafterfault_d\\badcodeafterfault_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
