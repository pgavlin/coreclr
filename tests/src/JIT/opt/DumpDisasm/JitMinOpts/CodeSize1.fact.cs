using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _DumpDisasm_JitMinOpts_CodeSize1_CodeSize1_
    {
        [OuterLoop]
        [Fact]
        public void _DumpDisasm_JitMinOpts_CodeSize1_CodeSize1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\DumpDisasm\\JitMinOpts\\CodeSize1\\CodeSize1.cmd");
        }
    }
}
