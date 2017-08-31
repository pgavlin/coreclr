using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_badcodeaftertry_d_badcodeaftertry_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeaftertry_d_badcodeaftertry_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeaftertry_d\\badcodeaftertry_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
