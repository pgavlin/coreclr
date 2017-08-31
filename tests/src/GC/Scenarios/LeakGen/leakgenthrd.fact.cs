using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _LeakGen_leakgenthrd_leakgenthrd_
    {
        [OuterLoop]
        [Fact]
        public void _LeakGen_leakgenthrd_leakgenthrd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\LeakGen\\leakgenthrd\\leakgenthrd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
