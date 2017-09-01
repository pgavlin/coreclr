using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _DumpDisasm_JitMinOpts_BBCnt1_BBCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _DumpDisasm_JitMinOpts_BBCnt1_BBCnt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\DumpDisasm\\JitMinOpts\\BBCnt1\\BBCnt1.cmd");
        }
    }
}
