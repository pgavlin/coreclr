using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _virtualstubdispatch_mixed_mixed_cs_r_mixed_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_mixed_mixed_cs_r_mixed_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\mixed\\mixed_cs_r\\mixed_cs_r.cmd");
        }
    }
}
