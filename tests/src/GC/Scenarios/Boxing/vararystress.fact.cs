using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Boxing_vararystress_vararystress_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_vararystress_vararystress_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\vararystress\\vararystress.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
