using CoreclrTestLib;
using Xunit;

namespace Interop_ICastable
{
    class _Castable_Castable_
    {
        [Fact]
        public void _Castable_Castable_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\ICastable\\Castable\\Castable.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
