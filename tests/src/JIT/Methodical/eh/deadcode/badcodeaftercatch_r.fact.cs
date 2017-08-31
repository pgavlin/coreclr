using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_badcodeaftercatch_r_badcodeaftercatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeaftercatch_r_badcodeaftercatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeaftercatch_r\\badcodeaftercatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
