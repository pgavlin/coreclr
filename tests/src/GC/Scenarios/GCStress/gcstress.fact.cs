using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _GCStress_gcstress_gcstress_
    {
        [Fact]
        public void _GCStress_gcstress_gcstress_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\GCStress\\gcstress\\gcstress.cmd");
        }
    }
}
