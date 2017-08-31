using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__speed_relcast_throw__speed_relcast_throw_
    {
        [OuterLoop]
        [Fact]
        public void _casts_SEH__speed_relcast_throw__speed_relcast_throw_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_speed_relcast_throw\\_speed_relcast_throw.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
