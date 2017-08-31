using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Boxing_gcvariant_gcvariant_
    {
        [Fact]
        public void _Boxing_gcvariant_gcvariant_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\gcvariant\\gcvariant.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
