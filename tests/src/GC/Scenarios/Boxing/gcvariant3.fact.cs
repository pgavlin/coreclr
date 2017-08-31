using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Boxing_gcvariant3_gcvariant3_
    {
        [Fact]
        public void _Boxing_gcvariant3_gcvariant3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\gcvariant3\\gcvariant3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
