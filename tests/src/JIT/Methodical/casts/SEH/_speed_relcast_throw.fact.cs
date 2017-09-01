using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_SEH__speed_relcast_throw__speed_relcast_throw_
    {
        [OuterLoop]
        [Fact]
        public void _casts_SEH__speed_relcast_throw__speed_relcast_throw_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_speed_relcast_throw\\_speed_relcast_throw.cmd");
        }
    }
}
