using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _muldimjagary_muldimjagary_muldimjagary_
    {
        [ActiveIssue("3392")]
        [Fact]
        public void _muldimjagary_muldimjagary_muldimjagary_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\muldimjagary\\muldimjagary\\muldimjagary.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
