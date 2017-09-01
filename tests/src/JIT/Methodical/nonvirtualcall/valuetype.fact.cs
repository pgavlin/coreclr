using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_valuetype_valuetype_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_valuetype_valuetype_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\valuetype\\valuetype.cmd");
        }
    }
}
