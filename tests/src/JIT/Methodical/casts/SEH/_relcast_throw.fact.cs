using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__relcast_throw__relcast_throw_
    {
        [OuterLoop]
        [Fact]
        public void _casts_SEH__relcast_throw__relcast_throw_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_relcast_throw\\_relcast_throw.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
