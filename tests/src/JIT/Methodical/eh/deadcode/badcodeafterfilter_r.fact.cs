using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_badcodeafterfilter_r_badcodeafterfilter_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_badcodeafterfilter_r_badcodeafterfilter_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\badcodeafterfilter_r\\badcodeafterfilter_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
