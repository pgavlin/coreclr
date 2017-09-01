using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _virtualstubdispatch_mixed_mixed_cs_do_mixed_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_mixed_mixed_cs_do_mixed_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\mixed\\mixed_cs_do\\mixed_cs_do.cmd");
        }
    }
}
