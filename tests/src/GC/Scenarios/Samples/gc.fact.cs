using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Samples_gc_gc_
    {
        [OuterLoop]
        [Fact]
        public void _Samples_gc_gc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Samples\\gc\\gc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
