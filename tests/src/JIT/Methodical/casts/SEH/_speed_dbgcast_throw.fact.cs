using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_SEH__speed_dbgcast_throw__speed_dbgcast_throw_
    {
        [OuterLoop]
        [Fact]
        public void _casts_SEH__speed_dbgcast_throw__speed_dbgcast_throw_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_speed_dbgcast_throw\\_speed_dbgcast_throw.cmd");
        }
    }
}
