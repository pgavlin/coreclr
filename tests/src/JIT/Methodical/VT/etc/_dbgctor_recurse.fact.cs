using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _VT_etc__dbgctor_recurse__dbgctor_recurse_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__dbgctor_recurse__dbgctor_recurse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_dbgctor_recurse\\_dbgctor_recurse.cmd");
        }
    }
}
