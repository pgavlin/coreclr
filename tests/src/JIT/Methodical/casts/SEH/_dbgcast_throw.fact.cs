using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_SEH__dbgcast_throw__dbgcast_throw_
    {
        [OuterLoop]
        [Fact]
        public void _casts_SEH__dbgcast_throw__dbgcast_throw_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_dbgcast_throw\\_dbgcast_throw.cmd");
        }
    }
}
