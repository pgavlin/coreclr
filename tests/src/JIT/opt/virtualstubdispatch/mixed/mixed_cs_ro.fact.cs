using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _virtualstubdispatch_mixed_mixed_cs_ro_mixed_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_mixed_mixed_cs_ro_mixed_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\mixed\\mixed_cs_ro\\mixed_cs_ro.cmd");
        }
    }
}
