using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_badcodeaftercatch_d_badcodeaftercatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeaftercatch_d_badcodeaftercatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeaftercatch_d\\badcodeaftercatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
