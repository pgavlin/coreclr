using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_valuetype_r_valuetype_r_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_valuetype_r_valuetype_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\valuetype_r\\valuetype_r.cmd");
        }
    }
}
