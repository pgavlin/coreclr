using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Boxing_gcvariant4_gcvariant4_
    {
        [Fact]
        public void _Boxing_gcvariant4_gcvariant4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\gcvariant4\\gcvariant4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
