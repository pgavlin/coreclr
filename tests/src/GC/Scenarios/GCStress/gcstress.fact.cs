using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _GCStress_gcstress_gcstress_
    {
        [Fact]
        public void _GCStress_gcstress_gcstress_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\GCStress\\gcstress\\gcstress.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
