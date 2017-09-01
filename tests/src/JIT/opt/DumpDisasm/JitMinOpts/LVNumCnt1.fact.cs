using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _DumpDisasm_JitMinOpts_LVNumCnt1_LVNumCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _DumpDisasm_JitMinOpts_LVNumCnt1_LVNumCnt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\DumpDisasm\\JitMinOpts\\LVNumCnt1\\LVNumCnt1.cmd");
        }
    }
}
