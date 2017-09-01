using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _DumpDisasm_JitMinOpts_LVRefCnt1_LVRefCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _DumpDisasm_JitMinOpts_LVRefCnt1_LVRefCnt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\DumpDisasm\\JitMinOpts\\LVRefCnt1\\LVRefCnt1.cmd");
        }
    }
}
