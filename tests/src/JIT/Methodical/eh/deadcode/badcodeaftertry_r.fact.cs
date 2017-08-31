using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_badcodeaftertry_r_badcodeaftertry_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeaftertry_r_badcodeaftertry_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeaftertry_r\\badcodeaftertry_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
