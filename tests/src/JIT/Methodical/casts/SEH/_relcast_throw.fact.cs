using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_SEH__relcast_throw__relcast_throw_
    {
        [OuterLoop]
        [Fact]
        public void _casts_SEH__relcast_throw__relcast_throw_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_relcast_throw\\_relcast_throw.cmd");
        }
    }
}
