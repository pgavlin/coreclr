using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _FragMan_fragman_fragman_
    {
        [OuterLoop]
        [Fact]
        public void _FragMan_fragman_fragman_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\FragMan\\fragman\\fragman.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
