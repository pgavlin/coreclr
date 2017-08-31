using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Boxing_gcvariant2_gcvariant2_
    {
        [Fact]
        public void _Boxing_gcvariant2_gcvariant2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\gcvariant2\\gcvariant2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
