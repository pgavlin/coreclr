using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_badcodeafterfilter_d_badcodeafterfilter_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeafterfilter_d_badcodeafterfilter_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeafterfilter_d\\badcodeafterfilter_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
